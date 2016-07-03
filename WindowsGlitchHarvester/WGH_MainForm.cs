using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using Delimon.Win32.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsGlitchHarvester
{
    public partial class WGH_MainForm : Form
    {

        public bool DontLoadSelectedStash = false;
        public bool DontLoadSelectedStockpile = false;

        int oysterClick = 0;

        ProcessHijack hijack = new ProcessHijack();

        public WGH_MainForm()
        {
            WGH_Core.Start(this);

            InitializeComponent();
        }

        private void btnBrowseTarget_Click(object sender, EventArgs e)
        {
            WGH_Core.LoadTarget();

            if(WGH_Core.currentMemoryInterface != null)
            {
                var mi = WGH_Core.currentMemoryInterface;

                if (mi.lastMemorySize != null)
                {
                    if (tbStartingAddress.Value > mi.lastMemorySize && tbStartingAddress.Maximum > mi.lastMemorySize)
                        tbStartingAddress.Value = (int)mi.lastMemorySize;

                    nmStartingAddress.Maximum = (int)mi.lastMemorySize;

                    if (tbBlastRange.Value > mi.lastMemorySize && tbBlastRange.Maximum > mi.lastMemorySize)
                        tbBlastRange.Value = (int)mi.lastMemorySize;

                    nmBlastRange.Maximum = (int)mi.lastMemorySize;

                    tbStartingAddress.Maximum = (int)mi.lastMemorySize;
                    tbBlastRange.Maximum = (int)mi.lastMemorySize;

                    WGH_Core.lastBlastLayerBackup = new BlastLayer();
                }
            }

			lbStashHistory.Items.Clear();
			lbStockpile.Items.Clear();

		}

        private void lbTargetName_Click(object sender, EventArgs e)
        {

        }

        private void btnBlastTarget_Click(object sender, EventArgs e)
        {

            if (WGH_Core.currentMemoryInterface == null)
            {
                MessageBox.Show("No target is loaded");
                return;
            }

            TerminateIfNeeded();

            if (WGH_Core.currentMemoryInterface == null)
                return;


            WGH_Core.RestoreTarget();


            var bl = WGH_Core.Blast();

            if (bl != null)
            {
                WGH_Core.currentStashkey = new StashKey(WGH_Core.GetRandomKey(), bl);

                DontLoadSelectedStash = true;
                lbStashHistory.Items.Add(WGH_Core.currentStashkey);
                lbStashHistory.SelectedIndex = lbStashHistory.Items.Count - 1;
                lbStockpile.ClearSelected();
            }

            WGH_Executor.Execute();

        }

        private void TerminateIfNeeded()
        {
            if (rbExecuteOtherProgram.Checked || rbExecuteWith.Checked || rbExecuteCorruptedFile.Checked)
                if (WGH_Core.currentTargetType == "File" && cbTerminateOnReExec.Checked && WGH_Executor.otherProgram != null)
                {
                    string otherProgramShortFilename = WGH_Executor.otherProgram.Substring(WGH_Executor.otherProgram.LastIndexOf(@"\") + 1);

                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.FileName = "taskkill";
                    startInfo.Arguments = $"/IM \"{otherProgramShortFilename}\"";
                    startInfo.RedirectStandardOutput = true;
                    startInfo.RedirectStandardError = true;
                    startInfo.UseShellExecute = false;
                    startInfo.CreateNoWindow = true;

                    Process processTemp = new Process();
                    processTemp.StartInfo = startInfo;
                    processTemp.EnableRaisingEvents = true;
                    try
                    {
                        processTemp.Start();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }

                    Thread.Sleep(300);
                }
        }

        private void btnRestoreFileBackup_Click(object sender, EventArgs e)
        {
            if (WGH_Core.currentMemoryInterface != null)
                WGH_Core.currentMemoryInterface.RestoreBackup(true);

        }

        private void WGH_MainForm_Load(object sender, EventArgs e)
        {
            cbCorruptionEngine.SelectedIndex = 0;
            cbBlastType.SelectedIndex = 0;

			this.Text = "Windows Glitch Harvester " + WGH_Core.WghVersion;


		}

        private void nmIntensity_ValueChanged(object sender, EventArgs e)
        {
            WGH_Core.Intensity = Convert.ToInt32(nmIntensity.Value);

            if (tbIntensity.Value != WGH_Core.Intensity)
                tbIntensity.Value = WGH_Core.Intensity;
        }

        private void tbIntensity_Scroll(object sender, EventArgs e)
        {
            WGH_Core.Intensity = tbIntensity.Value;

            if (nmIntensity.Value != WGH_Core.Intensity)
                nmIntensity.Value = WGH_Core.Intensity;
        }

        private void nmStartingAddress_ValueChanged(object sender, EventArgs e)
        {
            WGH_Core.StartingAddress = Convert.ToInt32(nmStartingAddress.Value);

            if (tbStartingAddress.Value != WGH_Core.StartingAddress)
                tbStartingAddress.Value = WGH_Core.StartingAddress;
        }

        private void tbStartingAddress_Scroll(object sender, EventArgs e)
        {
            WGH_Core.StartingAddress = tbStartingAddress.Value;

            if (nmStartingAddress.Value != WGH_Core.StartingAddress)
                nmStartingAddress.Value = WGH_Core.StartingAddress;
        }

        private void cbBlastRange_CheckedChanged(object sender, EventArgs e)
        {
            WGH_Core.useBlastRange = cbBlastRange.Checked;
        }

        private void nmBlastRange_ValueChanged(object sender, EventArgs e)
        {
            WGH_Core.BlastRange = Convert.ToInt32(nmBlastRange.Value);

            if (tbBlastRange.Value != WGH_Core.BlastRange)
                tbBlastRange.Value = WGH_Core.BlastRange;
        }

        private void tbBlastRange_Scroll(object sender, EventArgs e)
        {
            WGH_Core.BlastRange = tbBlastRange.Value;

            if (nmBlastRange.Value != WGH_Core.BlastRange)
                nmBlastRange.Value = WGH_Core.BlastRange;
        }

        private void cbCorruptionEngine_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cbCorruptionEngine.SelectedText)
            {
                case "NIGHTMARE":
                case "CHAOS":
                case "DOTS":
                    WGH_Core.selectedEngine = CorruptionEngine.NIGHTMARE;
                    break;
                
                case "PATCH":
                    WGH_Core.selectedEngine = CorruptionEngine.PATCH;
                    break;
            }
        }

        private void btnResetBackup_Click(object sender, EventArgs e)
        {
			if (MessageBox.Show(
@"This resets the backup of the current target by using the current data from it.
If you override a clean backup uaing a corrupted file,
you won't be able to restore the original file using it.

Are you sure you want to reset the current target's backup?", "WARNING", MessageBoxButtons.YesNo) == DialogResult.No)
				return;

			if (WGH_Core.currentMemoryInterface != null)
                WGH_Core.currentMemoryInterface.ResetBackup(true);

        }

        private void btnClearAllBackups_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to clear ALL THE BACKUPS\n from the Glitch Harvester's cache?", "WARNING", MessageBoxButtons.YesNo) == DialogResult.No)
                return;


            if(WGH_Core.currentMemoryInterface != null && WGH_Core.currentTargetType == "File")
                WGH_Core.currentMemoryInterface.RestoreBackup();

            foreach (string file in Directory.GetFiles(WGH_Core.currentDir + "\\TEMP"))
            {
               tryDeleteAgain:
                try {
                File.Delete(file);
                }
                catch
                {
                    if (MessageBox.Show($"Could not delete file {file} , try again?", "WARNING", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        goto tryDeleteAgain;
                }
            }

            if(WGH_Core.currentMemoryInterface != null && (WGH_Core.currentTargetType == "File" || WGH_Core.currentTargetType == "MultipleFiles"))
                WGH_Core.currentMemoryInterface.ResetBackup(false);

            MessageBox.Show("All the backups were cleared.");
        }

        private void rbTargetFile_CheckedChanged(object sender, EventArgs e)
        {
            btnResetBackup.Enabled = true;
            btnRestoreFileBackup.Enabled = true;
            cbWriteCopyMode.Enabled = true;

            rbExecuteCorruptedFile.Enabled = true;
            rbExecuteWith.Enabled = true;
        }

        private void rbTargetMultipleFiles_CheckedChanged(object sender, EventArgs e)
        {
            btnResetBackup.Enabled = true;
            btnRestoreFileBackup.Enabled = true;
            cbWriteCopyMode.Enabled = true;

            if (rbExecuteCorruptedFile.Checked)
                rbNoExecution.Checked = true;
            rbExecuteCorruptedFile.Enabled = false;

            if (rbExecuteWith.Checked)
                rbNoExecution.Checked = true;
            rbExecuteWith.Enabled = false;

        }

        private void rbTargetProcess_CheckedChanged(object sender, EventArgs e)
        {
            btnResetBackup.Enabled = false;
            btnRestoreFileBackup.Enabled = false;
            cbWriteCopyMode.Enabled = false;

            rbExecuteCorruptedFile.Enabled = false;
            rbExecuteWith.Enabled = false;

            if (rbExecuteCorruptedFile.Checked || rbExecuteWith.Checked || rbExecuteOtherProgram.Checked)
                rbNoExecution.Checked = true;
        }

        private void WGH_MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (WGH_Core.currentMemoryInterface != null)
                WGH_Core.RestoreTarget();
        }

        private void cbBlastType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cbBlastType.SelectedItem.ToString())
            {
                case "RANDOM":
                    WGH_NightmareEngine.Algo = BlastByteAlgo.RANDOM;
                    break;
                case "RANDOMTILT":
                    WGH_NightmareEngine.Algo = BlastByteAlgo.RANDOMTILT;
                    break;
                case "TILT":
                    WGH_NightmareEngine.Algo = BlastByteAlgo.TILT;
                    break;
            }
        }

        private void btnClearStockpile_Click(object sender, EventArgs e) =>ClearStockpile();
		public void ClearStockpile(bool force = false)
		{
			if (force || MessageBox.Show("Are you sure you want to clear the stockpile?", "Clearing stockpile", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				lbStockpile.Items.Clear();

				//RTC_Restore.SaveRestore();
			}
		}

        private void cbWriteCopyMode_CheckedChanged(object sender, EventArgs e)
        {
                WGH_Core.writeCopyMode = cbWriteCopyMode.Checked;
        }

        private void btnClearStashHistory_Click(object sender, EventArgs e)
        {
            lbStashHistory.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WGH_Core.ProcessHookName = tbProcessName.Text;
            if (tbProcessName.Text.Trim() == "")
                return;

            var allProcesses = Process.GetProcesses();

            hijack.HookToProcess(WGH_Core.ProcessHookName);
            

            MessageBox.Show("hooked to process named " + WGH_Core.ProcessHookName + ", MemorySize: " + hijack.processSize.ToString());
            new object();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var data = hijack.ReadAllData();
            File.WriteAllBytes(WGH_Core.ProcessHookName + ".txt", data);
            MessageBox.Show($"Extracted process named {WGH_Core.ProcessHookName} to {WGH_Core.ProcessHookName}.txt");
            new object();
        }

        private void btnInjectSelected_Click(object sender, EventArgs e)
        {
            if (WGH_Core.currentMemoryInterface == null)
            {
                MessageBox.Show("No target is loaded");
                return;
            }

            TerminateIfNeeded();

            StashKey sk = null;

            if (lbStashHistory.SelectedIndex != -1)
            {
                sk = (StashKey)lbStashHistory.SelectedItem;
            }
            else if(lbStockpile.SelectedIndex != -1)
            {
                sk = (StashKey)lbStockpile.SelectedItem;
            }

            if(sk != null)
            {

                WGH_Core.RestoreTarget();

                sk.Run();
                WGH_Executor.Execute();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {


            for(int i = 0; i<100; i++)
                hijack.WriteByte((byte)WGH_Core.RND.Next(0, 255), WGH_Core.LongRandom(0, hijack.processSize));


        }

        private void btnEditExec_Click(object sender, EventArgs e)
        {
            WGH_Executor.EditExec();
        }

        private void rbNoExecution_CheckedChanged(object sender, EventArgs e)
        {
            WGH_Executor.RefreshLabel();
        }

        private void rbExecuteCorruptedFile_CheckedChanged(object sender, EventArgs e)
        {
            WGH_Executor.RefreshLabel();
        }

        private void rbExecuteOtherProgram_CheckedChanged(object sender, EventArgs e)
        {
            WGH_Executor.RefreshLabel();
        }

        private void rbExecuteScript_CheckedChanged(object sender, EventArgs e)
        {
            WGH_Executor.RefreshLabel();
        }

		private void btnAddStashToStockpile_Click(object sender, EventArgs e)
        {

			AddStashToStockpile();

			//RTC_Restore.SaveRestore();
        }

        public void AddStashToStockpile()
        {
            if (lbStashHistory.Items.Count == 0 || lbStashHistory.SelectedIndex == -1)
            {
                MessageBox.Show("Can't add the Stash to the Stockpile because none is selected in the Stash History");
                return;
            }

            string Name = "";
            string value = "";

            if (this.InputBox("Harvester", "Enter the new Stash name:", ref value) == DialogResult.OK)
            {
                Name = value.Trim();
            }
            else
            {
                return;
            }


            if (!String.IsNullOrWhiteSpace(Name))
                WGH_Core.currentStashkey.Alias = Name;
            else
                WGH_Core.currentStashkey.Alias = WGH_Core.currentStashkey.Key;

            lbStockpile.Items.Add(WGH_Core.currentStashkey);
            lbStashHistory.Items.RemoveAt(lbStashHistory.SelectedIndex);

            DontLoadSelectedStockpile = true;
            lbStockpile.SelectedIndex = lbStockpile.Items.Count - 1;

        }

        public DialogResult InputBox(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }


        private void lbStashHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DontLoadSelectedStash || lbStashHistory.SelectedIndex == -1)
            {
                DontLoadSelectedStash = false;
                return;
            }


            lbStockpile.ClearSelected();

            WGH_Core.currentStashkey = (lbStashHistory.SelectedItem as StashKey);

            if (cbInjectOnSelect.Checked)
                btnInjectSelected_Click(sender, e);
        }

        private void lbStockpile_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DontLoadSelectedStockpile || lbStockpile.SelectedIndex == -1)
            {
                DontLoadSelectedStockpile = false;
                return;
            }

            lbStashHistory.ClearSelected();

            WGH_Core.currentStashkey = (lbStockpile.SelectedItem as StashKey);

            if (cbInjectOnSelect.Checked)
                btnInjectSelected_Click(sender, e);
        }

        private void btnRemoveSelected_Click(object sender, EventArgs e) => RemoveSelected();
		public void RemoveSelected(bool force = false)
		{
			if (lbStockpile.SelectedIndex != -1)
				if(force || MessageBox.Show($"Are you sure you want to remove item \"{lbStockpile.SelectedItem.ToString()}\" from Stockpile?", "Remove Item", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					lbStockpile.Items.RemoveAt(lbStockpile.SelectedIndex);
					//RTC_Restore.SaveRestore();
				}
		}

        private void btnLoadStockpile_Click(object sender, EventArgs e)
        {
			if (WGH_Core.currentMemoryInterface == null)
			{
				MessageBox.Show("No target is loaded");
				return;
			}

			Stockpile.Load();
        }

        private void btnSaveStockpileAs_Click(object sender, EventArgs e)
        {
            if (lbStockpile.Items.Count == 0)
            {
                MessageBox.Show("You cannot save the Stockpile because it is empty");
                return;
            }

            Stockpile sks = new Stockpile(lbStockpile);
            Stockpile.Save(sks);
        }

        private void btnSaveStockpile_Click(object sender, EventArgs e)
        {
            Stockpile sks = new Stockpile(lbStockpile);
            Stockpile.Save(sks, true);
        }


        private void btnEnableCaching_Click(object sender, EventArgs e)
        {
            if(WGH_Core.currentMemoryInterface != null)
                if(btnEnableCaching.Text == "Enable caching on current target")
                {
                    WGH_Core.currentMemoryInterface.getMemoryDump();
                    btnEnableCaching.Text = "Disable caching on current target";
                }
                else
                {
                    WGH_Core.currentMemoryInterface.lastMemoryDump = null;
                    btnEnableCaching.Text = "Enable caching on current target";
                }
        }

        private void btnDisableAutoUncorrupt_Click(object sender, EventArgs e)
        {
            if (!WGH_Core.AutoUncorrupt)
                if (btnDisableAutoUncorrupt.Text == "Enable Auto-Uncorrupt")
                {
                    WGH_Core.AutoUncorrupt = true;
                    btnDisableAutoUncorrupt.Text = "Disable Auto-Uncorrupt";
                }
                else
                {
                    WGH_Core.AutoUncorrupt = false;
                    btnDisableAutoUncorrupt.Text = "Enable Auto-Uncorrupt";
                }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void btn4d3d3d3_Click(object sender, EventArgs e)
        {
            oysterClick++;

            if (oysterClick > 10)
            {
                btn4d3d3d3.Visible = false;
                pictureBox1.Image = global::WindowsGlitchHarvester.Properties.Resources.oyster;
                return;
            }

            if (pictureBox1.Image == null)
                pictureBox1.Image = global::WindowsGlitchHarvester.Properties.Resources.tayne_flarhgunnstow;
            else
                pictureBox1.Image = global::WindowsGlitchHarvester.Properties.Resources._4d3d3d3;
        }

        private void btnExecCosmo_Click(object sender, EventArgs e)
        {



        }

        public static byte[] StringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }

		private void btnStashHistoryUp_Click(object sender, EventArgs e)
		{
			if (lbStashHistory.SelectedIndex == -1)
				return;

			if (lbStashHistory.SelectedIndex == lbStashHistory.Items.Count - 1)
				lbStashHistory.SelectedIndex = 0;
			else
				lbStashHistory.SelectedIndex++;

			//RTC_Restore.SaveRestore();
		}

		private void btnStashHistoryDown_Click(object sender, EventArgs e)
		{
			if (lbStashHistory.SelectedIndex == -1)
				return;

			if (lbStashHistory.SelectedIndex == lbStashHistory.Items.Count - 1)
				lbStashHistory.SelectedIndex = 0;
			else
				lbStashHistory.SelectedIndex++;

			//RTC_Restore.SaveRestore();
		}

		private void btnStockpileUp_Click(object sender, EventArgs e)
		{
			if (lbStockpile.SelectedIndex == -1)
				return;

			if (lbStockpile.SelectedIndex == 0)
				lbStockpile.SelectedIndex = lbStockpile.Items.Count - 1;
			else
				lbStockpile.SelectedIndex--;

			//RTC_Restore.SaveRestore();
		}

		private void btnStockpileDown_Click(object sender, EventArgs e)
		{
			if (lbStockpile.SelectedIndex == -1)
				return;

			if (lbStockpile.SelectedIndex == lbStockpile.Items.Count - 1)
				lbStockpile.SelectedIndex = 0;
			else
				lbStockpile.SelectedIndex++;

			//RTC_Restore.SaveRestore();
		}

		private void btnStockpileMoveDown_Click(object sender, EventArgs e)
		{
			if (lbStockpile.Items.Count < 2)
				return;

			object o = lbStockpile.SelectedItem;
			int pos = lbStockpile.SelectedIndex;
			int count = lbStockpile.Items.Count;
			lbStockpile.Items.RemoveAt(pos);

			DontLoadSelectedStockpile = true;

			if (pos == count - 1)
			{
				lbStockpile.Items.Insert(0, o);
				lbStockpile.SelectedIndex = 0;
			}
			else
			{
				lbStockpile.Items.Insert(pos + 1, o);
				lbStockpile.SelectedIndex = pos + 1;
			}

			//RTC_Restore.SaveRestore();
		}

		private void btnStockpileMoveUp_Click(object sender, EventArgs e)
		{

			if (lbStockpile.Items.Count < 2)
				return;

			object o = lbStockpile.SelectedItem;
			int pos = lbStockpile.SelectedIndex;
			int count = lbStockpile.Items.Count;
			lbStockpile.Items.RemoveAt(pos);

			DontLoadSelectedStockpile = true;


			if (pos == 0)
			{
				lbStockpile.Items.Add(o);
				lbStockpile.SelectedIndex = count - 1;
			}
			else
			{
				lbStockpile.Items.Insert(pos - 1, o);
				lbStockpile.SelectedIndex = pos - 1;
			}

			//RTC_Restore.SaveRestore();

		}

		private void btnRenameSelected_Click(object sender, EventArgs e)
		{
			if (lbStockpile.SelectedIndex != -1)
			{

				string Name = "";
				string value = "";

				if (this.InputBox("Harvester", "Enter the new Stash name:", ref value) == DialogResult.OK)
				{
					Name = value.Trim();
				}
				else
				{
					return;
				}

				(lbStockpile.SelectedItem as StashKey).Alias = Name;
				lbStockpile.RefreshItemsReal();

			}

		}

		private void btnImportStockpile_Click(object sender, EventArgs e)
		{
			if (WGH_Core.currentMemoryInterface == null)
			{
				MessageBox.Show("No target is loaded");
				return;
			}

			Stockpile.Import();

			//RTC_Restore.SaveRestore();
		}
	}
}
