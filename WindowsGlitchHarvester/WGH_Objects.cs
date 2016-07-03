using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Delimon.Win32.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Drawing;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;

namespace WindowsGlitchHarvester
{

    public class LabelPassthrough : Label
    {

        protected override void OnPaint(PaintEventArgs e)
        {
            TextRenderer.DrawText(e.Graphics, this.Text.ToString(), this.Font, ClientRectangle, ForeColor);
        }

    }

	public class RefreshingListBox : ListBox
	{
		public void RefreshItemsReal()
		{
			base.RefreshItems();
		}
	}

    public class MenuButton : Button
    {
        [DefaultValue(null)]
        public ContextMenuStrip Menu { get; set; }

        public void SetMenu(ContextMenuStrip _menu)
        {
            Menu = _menu;
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);

            if (Menu != null && mevent.Button == MouseButtons.Left)
            {
                Menu.Show(this, mevent.Location);
            }
        }

        /*
        protected override void OnPaint(PaintEventArgs pevent)
        {

            base.OnPaint(pevent);
            
            int arrowX = ClientRectangle.Width - 14;
            int arrowY = ClientRectangle.Height / 2 - 1;

            Brush brush = Enabled ? SystemBrushes.ControlText : SystemBrushes.ButtonShadow;
            Point[] arrows = new Point[] { new Point(arrowX, arrowY), new Point(arrowX + 7, arrowY), new Point(arrowX + 3, arrowY + 4) };
            pevent.Graphics.FillPolygon(brush, arrows);
             
        }
        */
    }

    [Serializable()]
    public class Stockpile
    {
        public List<StashKey> stashkeys = new List<StashKey>();

        public string Filename;
        public string ShortFilename;
		public string WghVersion;

		public string descrip = "";

        public string Name;
        public string CloudCorruptID = null;

        public List<string> ComputerSerials = new List<string>();
        public List<string> MakersName = new List<string>();
        public List<string> MakersID = new List<string>();


        public Stockpile(ListBox lbStockpile)
        {
            foreach (StashKey sk in lbStockpile.Items)
            {
                stashkeys.Add(sk);
            }
        }

        public override string ToString()
        {
            return (Name != null ? Name : "");
        }


        public static void Save(Stockpile sks)
        {
            Stockpile.Save(sks, false);
        }

        public static void Save(Stockpile sks, bool IsQuickSave)
        {
            if (sks.stashkeys.Count == 0)
            {
                MessageBox.Show("Can't save because the Current Stockpile is empty");
                return;
            }

            if (!IsQuickSave)
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.DefaultExt = "sks";
                saveFileDialog1.Title = "Save Stockpile File";
                saveFileDialog1.Filter = "SKS files|*.sks";
                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    sks.Filename = saveFileDialog1.FileName;
                    sks.ShortFilename = sks.Filename.Substring(sks.Filename.LastIndexOf("\\") + 1, sks.Filename.Length - (sks.Filename.LastIndexOf("\\") + 1));
                }
                else
                    return;
            }
            else
            {
                sks.Filename = WGH_Core.currentStockpile.Filename;
                sks.ShortFilename = WGH_Core.currentStockpile.ShortFilename;
            }

			//Watermarking WGH Version
			sks.WghVersion = WGH_Core.WghVersion;


			System.IO.FileStream FS;
            BinaryFormatter bformatter = new BinaryFormatter();

            //creater master.sk to temp folder from stockpile object

			if(File.Exists(WGH_Core.currentDir + "\\TEMP\\master.sk"))
				FS = File.Open(WGH_Core.currentDir + "\\TEMP\\master.sk", FileMode.Open);
			else
				FS = File.Open(WGH_Core.currentDir + "\\TEMP\\master.sk", FileMode.Create);

			bformatter.Serialize(FS, sks);
            FS.Close();


            //7z the temp folder to destination filename
            string[] stringargs = { "-c", sks.Filename, WGH_Core.currentDir + "\\TEMP\\" };
            FastZipProgram.Exec(stringargs);

            Load(sks.Filename); //Reload file after for test and clean

        }

        public static void Load()
        {
            Load(null);
        }

        public static void Load(string Filename)
        {

            //clean temp folder
            foreach (string file in Directory.GetFiles(WGH_Core.currentDir + "\\TEMP"))
                File.Delete(file);

            if (Filename == null)
            {
                OpenFileDialog OpenFileDialog1 = new OpenFileDialog();
                OpenFileDialog1.DefaultExt = "sks";
                OpenFileDialog1.Title = "Open Stockpile File";
                OpenFileDialog1.Filter = "SKS files|*.sks";
                OpenFileDialog1.RestoreDirectory = true;
                if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Filename = OpenFileDialog1.FileName.ToString();
                }
                else
                    return;
            }

            if (!File.Exists(Filename))
            {
                MessageBox.Show("The Stockpile file wasn't found");
                return;
            }

            //7z extract part

            string[] stringargs = { "-x", Filename, WGH_Core.currentDir + "\\TEMP\\" };

            FastZipProgram.Exec(stringargs);

            if (!File.Exists(WGH_Core.currentDir + "\\TEMP\\master.sk"))
            {
                MessageBox.Show("The file could not be read properly");
                return;
            }



            //stockpile part
            System.IO.FileStream FS;
            BinaryFormatter bformatter = new BinaryFormatter();

            Stockpile sks;
            bformatter = new BinaryFormatter();

            try
            {
                FS = File.Open(WGH_Core.currentDir + "\\TEMP\\master.sk", FileMode.Open);
                sks = (Stockpile)bformatter.Deserialize(FS);
                FS.Close();
            }
            catch
            {
                MessageBox.Show("The Stockpile file could not be loaded");
                return;
            }

            WGH_Core.currentStockpile = sks;


            //fill list controls
            WGH_Core.ghForm.lbStockpile.Items.Clear();

            foreach (StashKey key in sks.stashkeys)
            {
                WGH_Core.ghForm.lbStockpile.Items.Add(key);
            }


            WGH_Core.ghForm.btnSaveStockpile.Enabled = true;
            WGH_Core.ghForm.btnSaveStockpile.BackColor = Color.Tomato;
            sks.Filename = Filename;

			if (sks.WghVersion != WGH_Core.WghVersion)
			{
				if (sks.WghVersion == null)
					MessageBox.Show("WARNING: You have loaded a pre-0.09 stockpile using WGH " + WGH_Core.WghVersion + "\n Items might not appear identical to how they when they were created.");
				else
					MessageBox.Show("WARNING: You have loaded a stockpile created with WGH " + sks.WghVersion + " using WGH " + WGH_Core.WghVersion + "\n Items might not appear identical to how they when they were created.");
			}

		}

        public static void Import()
        {
            Import(null, false);
        }

        public static void Import(string Filename, bool CorruptCloud)
        {

            //clean temp folder
            foreach (string file in Directory.GetFiles(WGH_Core.currentDir + "\\TEMP3"))
                File.Delete(file);

            if (Filename == null)
            {
                OpenFileDialog OpenFileDialog1 = new OpenFileDialog();
                OpenFileDialog1.DefaultExt = "sks";
                OpenFileDialog1.Title = "Open Stockpile File";
                OpenFileDialog1.Filter = "SKS files|*.sks";
                OpenFileDialog1.RestoreDirectory = true;
                if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Filename = OpenFileDialog1.FileName.ToString();
                }
                else
                    return;
            }

            if (!File.Exists(Filename))
            {
                MessageBox.Show("The Stockpile file wasn't found");
                return;
            }

            //7z extract part

            string[] stringargs = { "-x", Filename, WGH_Core.currentDir + "\\TEMP3\\" };

            FastZipProgram.Exec(stringargs);

            if (!File.Exists(WGH_Core.currentDir + "\\TEMP3\\master.sk"))
            {
                MessageBox.Show("The file could not be read properly");
                return;
            }



            //stockpile part
            System.IO.FileStream FS;
            BinaryFormatter bformatter = new BinaryFormatter();

            Stockpile sks;
            bformatter = new BinaryFormatter();

            try
            {
                FS = File.Open(WGH_Core.currentDir + "\\TEMP3\\master.sk", FileMode.Open);
                sks = (Stockpile)bformatter.Deserialize(FS);
                FS.Close();
            }
            catch
            {
                MessageBox.Show("The Stockpile file could not be loaded");
                return;
            }


            //fill list controls

            foreach (StashKey key in sks.stashkeys)
            {
                WGH_Core.ghForm.lbStockpile.Items.Add(key);
            }

        }

    }



    [Serializable()]
    public class StashKey
    {

        public String TargetId;
        public String TargetType;
        public List<string> MemoryZones = new List<string>();
        public String TargetName;

        public String Key;
        public String ParentKey = null;
        public BlastLayer blastlayer = null;

        public String Alias
        {
            get
            {
                if (_Alias != null)
                    return _Alias;
                else
                    return Key;
            }
            set
            {
                _Alias = value;
            }
        }

        private String _Alias;

        public StashKey(String _key, BlastLayer _blastlayer)
        {

            Key = _key;
            blastlayer = _blastlayer;
            TargetId = WGH_Core.currentTargetName;
            TargetType = WGH_Core.currentTargetType;
            TargetName = WGH_Core.currentTargetName;

        }

        public override string ToString()
        {
            return Alias;
        }

        public bool Run()
        {
            WGH_Core.Blast(blastlayer);
            return (blastlayer.Layer.Count > 0);
        }

    }


    [Serializable()]
    public class BlastLayer
    {
        public List<BlastUnit> Layer;

        public BlastLayer()
        {
            Layer = new List<BlastUnit>();
        }

        public BlastLayer(List<BlastUnit> _layer)
        {
            Layer = _layer;
        }

        public void Apply()
        {
            WGH_Core.lastBlastLayerBackup = GetBackup();

            foreach (BlastUnit bb in Layer)
                bb.Apply();
        }

        public BlastLayer GetBackup()
        {
            List<BlastUnit> BackupLayer = new List<BlastUnit>(); ;

            foreach (BlastUnit bb in Layer)
                BackupLayer.Add(bb.GetBackup());

            BlastLayer Recovery = new BlastLayer(BackupLayer);

            return Recovery;
        }

    }

    [Serializable()]
    public abstract class BlastUnit
    {
        public abstract void Apply();
        public abstract BlastUnit GetBackup();
    }

    [Serializable()]
    public class BlastByte : BlastUnit
    {
        public string Domain;
        public long Address;
        public BlastByteType Type;
        public int Value;
        public bool IsEnabled;

        public BlastByte(string _domain, long _address, BlastByteType _type, int _value, bool _isEnabled)
        {
            Domain = _domain;
            Address = _address;
            Type = _type;
            Value = _value;
            IsEnabled = _isEnabled;
        }

        public override void Apply()
        {
            if (!IsEnabled)
                return;

            try
            {
                MemoryInterface mi = WGH_Core.currentMemoryInterface;

                if (mi == null)
                    return;

                switch (Type)
                {
                    case BlastByteType.SET:
                        mi.setByte(Address, (byte)Value);
                        break;

                    case BlastByteType.ADD:
                        mi.setByte(Address, (byte)(mi.getByte(Address) + Value));
                        break;

                    case BlastByteType.SUBSTRACT:
                        mi.setByte(Address, (byte)(mi.getByte(Address) - Value));
                        break;

                    case BlastByteType.NONE:
                        return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("The BlastByte apply() function threw up. \n\n" +
                ex.ToString());
                return;
            }

        }

        public override BlastUnit GetBackup()
        {
            if (!IsEnabled)
                return null;

            try
            {
                MemoryInterface mi = WGH_Core.currentMemoryInterface;

                if (mi == null || Type == BlastByteType.NONE)
                    return null;

                return new BlastByte(Domain, Address, BlastByteType.SET, (int)mi.getByte(Address), true);

            }
            catch (Exception ex)
            {
                MessageBox.Show("The BlastByte apply() function threw up. \n" +
                "This is not a BizHawk error so you should probably send a screenshot of this to the devs\n\n" +
                ex.ToString());
                return null;
            }

        }

        public override string ToString()
        {
            string EnabledString = "[ ] ";
            if (IsEnabled)
                EnabledString = "[x] ";

            string cleanDomainName = Domain.Replace("(nametables)", ""); //Shortens the domain name if it contains "(nametables)"
            return (EnabledString + cleanDomainName + "(" + Convert.ToInt32(Address).ToString() + ")." + Type.ToString() + "(" + Value.ToString() + ")");
        }
    }

    [Serializable()]
    public abstract class MemoryInterface
    {
        public abstract byte[] getMemoryDump();
        public abstract byte[] lastMemoryDump { get; set; }
        public abstract int getMemorySize();
        public abstract int? lastMemorySize{ get; set; }

        public abstract void setByte(long address, byte data);
        public abstract void setBytes(long address, byte[] data);
        public abstract byte? getByte(long address);
        public abstract byte[] getBytes(long address, long range);

        public abstract void SetBackup();
        public abstract void ResetBackup(bool askConfirmation = true);
        public abstract void RestoreBackup(bool announce = true);
        public abstract void ResetWorkingFile();
        public abstract void ApplyWorkingFile();

    }

    [Serializable()]
    public class FileInterface : MemoryInterface
    {
        public string filename;
        public string shortFilename;
        bool writeDirectly = false;
        System.IO.Stream stream = null;

        public FileInterface(string _targetId)
        {
            try
            {
                string[] targetId = _targetId.Split('|');
                filename = targetId[1];
                shortFilename = filename.Substring(filename.LastIndexOf("\\") + 1, filename.Length - (filename.LastIndexOf("\\") + 1));

                SetBackup();

                //getMemoryDump();
                getMemorySize();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"FileInterface failed to load something \n\n" + "Culprit file: " + filename + "\n\n" + ex.ToString());

                if(WGH_Core.ghForm.rbTargetMultipleFiles.Checked)
                    throw;
            }
        }

        public string getCompositeFilename(string prefix)
        {
            return $"{prefix.Trim().ToUpper()}^{filename.ToBase64()}^{shortFilename}";
        }

        public string getCorruptFilename(bool overrideWriteCopyMode = false)
        {
            if(overrideWriteCopyMode || WGH_Core.writeCopyMode)
                return WGH_Core.currentDir + "\\TEMP\\" + getCompositeFilename("CORRUPT");
            else
                return filename;
        }
        public string getBackupFilename()
        {
            return WGH_Core.currentDir + "\\TEMP\\" + getCompositeFilename("BACKUP");
        }

        public override void ResetWorkingFile()
        {

        tryDeleteResetWorkingFileAgain:
            try
            {
                if (File.Exists(getCorruptFilename()))
                    File.Delete(getCorruptFilename());
            }
            catch
            {
                MessageBox.Show($"Could not get access to {getCorruptFilename()}\n\nClose the file then press OK", "WARNING");
                    goto tryDeleteResetWorkingFileAgain;
            }
            

            SetWorkingFile();
        }

        public string SetWorkingFile()
        {
            if (!File.Exists(getCorruptFilename()))
                File.Copy(getBackupFilename(), getCorruptFilename(), true);

            return getCorruptFilename();
        }

        public override void ApplyWorkingFile()
        {
            if(stream != null)
            {
                stream.Close();
                stream = null;
            }

            if(WGH_Core.writeCopyMode)
            {

            tryApplyWorkingFileAgain:
                try
                {
                    if (File.Exists(filename))
                        File.Delete(filename);

                    if (File.Exists(getCorruptFilename()))
                        File.Move(getCorruptFilename(), filename);
                }
                catch
                {
                    MessageBox.Show($"Could not get access to {filename} because some other program is probably using it. \n\nClose the file then press OK to try again", "WARNING");
                    goto tryApplyWorkingFileAgain;
                }

            }
        }

        public override void SetBackup()
        {
            if (!File.Exists(getBackupFilename()))
                File.Copy(filename, getBackupFilename(), true);
        }

        public override void ResetBackup(bool askConfirmation = true)
        {
            if (askConfirmation && MessageBox.Show("Are you sure you want to reset the backup using the target file?", "WARNING", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            if (File.Exists(getBackupFilename()))
                File.Delete(getBackupFilename());

            SetBackup();

        }

        public override void RestoreBackup(bool announce = true)
        {

            if (File.Exists(getBackupFilename()))
            {
                File.Delete(filename);
                File.Copy(getBackupFilename(), filename, true);

                if (announce)
                    MessageBox.Show("Backup of " + shortFilename + " was restored");
            }
            else
            {
                MessageBox.Show("Couldn't find backup of " + shortFilename);
            }
        }

        public override byte[] getMemoryDump()
        {
            lastMemoryDump = File.ReadAllBytes(getBackupFilename());
            return lastMemoryDump;
        }
        public override byte[] lastMemoryDump { get; set; } = null;

        public override int getMemorySize()
        {
            if (lastMemorySize != null)
                return (int)lastMemorySize;

            lastMemorySize = (int)new FileInfo(filename).Length;
            return (int)lastMemorySize;
            
        }

        public override int? lastMemorySize { get; set; }

        public override void setBytes(long address, byte[] data)
        {
            if (stream == null)
                stream = File.Open(SetWorkingFile(), FileMode.Open);

            stream.Position = address;
            stream.Write(data, 0, data.Length);

            if (lastMemoryDump != null)
            for (int i = 0; i<data.Length; i++)
                lastMemoryDump[address + i] = data[i];

        }

        public override void setByte(long address, byte data)
        {
            if (stream == null)
                stream = File.Open(SetWorkingFile(), FileMode.Open);

            stream.Position = address;
            stream.WriteByte(data);

            if (lastMemoryDump != null)
                lastMemoryDump[address] = data;
        }

        public override byte? getByte(long address)
        {

            if (lastMemoryDump != null)
                return lastMemoryDump[address];

            if (stream == null)
                stream = File.Open(SetWorkingFile(), FileMode.Open);

            byte[] readBytes = new byte[1];
            stream.Position = address;
            stream.Read(readBytes, 0, 1);

            //fs.Close();

            return readBytes[0];

        }

        public override byte[] getBytes(long address, long range)
        {

            if (lastMemoryDump == null)
                return lastMemoryDump.SubArray(address, range);

            if (stream == null)
                stream = File.Open(SetWorkingFile(), FileMode.Open);

            byte[] readBytes = new byte[range];
            stream.Position = address;
            stream.Read(readBytes, 0, (int)range);

            //fs.Close();

            return readBytes;


        }

    }


    [Serializable()]
    public class MultipleFileInterface : MemoryInterface
    {
        public string filename;
        public string shortFilename;
        //bool writeDirectly = false;
        //Stream stream = null;

        public List<FileInterface> fileInterfaces = new List<FileInterface>();

        public MultipleFileInterface(string _targetId)
        {
            try
            {
                string[] targetId = _targetId.Split('|');

                for (int i = 0; i < targetId.Length; i++)
                    fileInterfaces.Add(new FileInterface("File|" + targetId[i]));

                filename = "MultipleFiles";
                shortFilename = "MultipleFiles";

                //SetBackup();

                //getMemoryDump();
                getMemorySize();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"MultipleFileInterface failed to load something \n\n" + ex.ToString());
            }
        }

        public string getCompositeFilename(string prefix)
        {
            return string.Join("|", fileInterfaces.Select(it => it.getCompositeFilename(prefix)));

        }

        public string getCorruptFilename(bool overrideWriteCopyMode = false)
        {
            return string.Join("|", fileInterfaces.Select(it => it.getCorruptFilename(overrideWriteCopyMode)));

        }

        public string getBackupFilename()
        {
            return string.Join("|", fileInterfaces.Select(it => it.getBackupFilename()));
        }

        public override void ResetWorkingFile()
        {
            foreach (var fi in fileInterfaces)
                fi.ResetWorkingFile();

        }

        public string SetWorkingFile()
        {
            return string.Join("|", fileInterfaces.Select(it => it.SetWorkingFile()));

        }

        public override void ApplyWorkingFile()
        {
            foreach (var fi in fileInterfaces)
                fi.ApplyWorkingFile();

        }

        public override void SetBackup()
        {
            foreach (var fi in fileInterfaces)
                fi.SetBackup();

        }

        public override void ResetBackup(bool askConfirmation = true)
        {
            if (askConfirmation && MessageBox.Show("Are you sure you want to reset the backup using the target files?", "WARNING", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            foreach (var fi in fileInterfaces)
                fi.ResetBackup(false);

        }

        public override void RestoreBackup(bool announce = true)
        {

            foreach (var fi in fileInterfaces)
                fi.RestoreBackup(false);

            if(announce)
                MessageBox.Show("Backups of " + string.Join(",",fileInterfaces.Select(it => (it as FileInterface).shortFilename)) + " were restored");

        }

        public override byte[] getMemoryDump()
        {

            List<byte> allBytes = new List<byte>();

            foreach(var fi in fileInterfaces)
                allBytes.AddRange(fi.getMemoryDump());

            lastMemoryDump = allBytes.ToArray();
            return lastMemoryDump;

        }
        public override byte[] lastMemoryDump { get; set; } = null;

        public override int getMemorySize()
        {
            int size = 0;

            foreach (var fi in fileInterfaces)
                size += fi.getMemorySize();

            lastMemorySize = size;
            return (int)lastMemorySize;

        }

        public override int? lastMemorySize { get; set; }

        public override void setBytes(long address, byte[] data)
        {
            int addressPad = 0;
            FileInterface targetInterface = null;

            foreach(var fi in fileInterfaces)
            {
                if (addressPad + fi.getMemorySize() > address)
                {
                    targetInterface = fi;
                    break;
                }

                addressPad += fi.getMemorySize();
                
            }

            if (targetInterface != null)
                targetInterface.setBytes(address - addressPad, data);

            if (lastMemoryDump != null)
                for (int i = 0; i < data.Length; i++)
                    lastMemoryDump[address + i] = data[i];

        }

        public override void setByte(long address, byte data)
        {

            int addressPad = 0;
            FileInterface targetInterface = null;

            foreach (var fi in fileInterfaces)
            {
                if (addressPad + fi.getMemorySize() > address)
                {
                    targetInterface = fi;
                    break;
                }

                addressPad += fi.getMemorySize();
                
            }

            if (targetInterface != null)
                targetInterface.setByte(address - addressPad, data);

            if (lastMemoryDump != null)
                lastMemoryDump[address] = data;
        }

        public override byte? getByte(long address)
        {

            if (lastMemoryDump != null)
                return lastMemoryDump[address];

            int addressPad = 0;
            FileInterface targetInterface = null;

            foreach (var fi in fileInterfaces)
            {
                if (addressPad + fi.getMemorySize() > address)
                {
                    targetInterface = fi;
                    break;
                }

                addressPad += fi.getMemorySize();

            }

            if (targetInterface != null)
                return targetInterface.getByte(address - addressPad);
            else
                return null;


        }

        public override byte[] getBytes(long address, long range)
        {
            
            if (lastMemoryDump != null)
                return lastMemoryDump.SubArray(address, range);
            

            int addressPad = 0;
            FileInterface targetInterface = null;

            foreach (var fi in fileInterfaces)
            {
                if (addressPad + fi.getMemorySize() > address)
                {
                    targetInterface = fi;
                    break;
                }

                addressPad += fi.getMemorySize();

            }

            if (targetInterface != null)
                return targetInterface.getBytes(address - addressPad,range);
            else
                return null;

        }

    }


    [Serializable()]
    public class ProcessInterface : MemoryInterface
    {
        string filename;

        //Memory mem

        public ProcessInterface(string _targetId)
        {
            string[] targetId = _targetId.Split(':');
            filename = targetId[1];
            getMemoryDump();
            getMemorySize();
        }

        public override byte[] getMemoryDump()
        {
            //HOOK CHEATENGINE API HERE
            //lastMemoryDump = File.ReadAllBytes(filename);
            return lastMemoryDump;
        }
        public override byte[] lastMemoryDump { get; set; } = null;

        public override int getMemorySize()
        {
            if (lastMemoryDump == null)
                getMemoryDump();

            if (lastMemoryDump == null)
                return 0;

            lastMemorySize = lastMemoryDump.Length;
            return (int)lastMemorySize;

        }

        public override int? lastMemorySize { get; set; }

        public override void setBytes(long address, byte[] data)
        {

            //HOOK CHEATENGINE API HERE
            /*
            using (Stream stream = File.Open(filename, FileMode.Open))
            {
                stream.Position = address;
                stream.Write(data, 0, data.Length);
            }
            */

            if (lastMemoryDump == null)
                getMemoryDump();

            if (lastMemoryDump == null)
                return;

            for (int i = 0; i < data.Length; i++)
            {
                lastMemoryDump[address + i] = data[i];
            }
        }

        public override void setByte(long address, byte data)
        {

            //HOOK CHEATENGINE API HERE
            /*
            using (Stream stream = File.Open(filename, FileMode.Open))
            {
                stream.Position = address;
                stream.WriteByte(data);
            }
            */

            if (lastMemoryDump == null)
                getMemoryDump();

            if (lastMemoryDump == null)
                return;

            lastMemoryDump[address] = data;
        }

        public override byte? getByte(long address)
        {
            if (lastMemoryDump == null)
                getMemoryDump();

            if (lastMemoryDump == null)
                return null;

            return lastMemoryDump[address];
        }

        public override byte[] getBytes(long address, long range)
        {
            if (lastMemoryDump == null)
                getMemoryDump();

            if (lastMemoryDump == null)
                return null;

            return lastMemoryDump.SubArray(address, range);
        }

        public override void SetBackup()
        {
            //CAN'T DO THAT WITH PROCESSES
        }

        public override void ResetBackup(bool askConfirmation = true)
        {
            //CAN'T DO THAT WITH PROCESSES
        }

        public override void RestoreBackup(bool announce = true)
        {
            //CAN'T DO THAT WITH PROCESSES
        }

        public override void ResetWorkingFile()
        {
            //CAN'T DO THAT WITH PROCESSES
        }

        public override void ApplyWorkingFile()
        {
            //CAN'T DO THAT WITH PROCESSES
        }

    }
}
