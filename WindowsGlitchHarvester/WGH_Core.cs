using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;
using Delimon.Win32.IO;
using System.Drawing;

namespace WindowsGlitchHarvester
{

    public static class WGH_Core
    {

        public static Random RND = new Random();
        public static string[] args;

        public static Timer ResizeTimer;
        public static Size ResizeSize;

        public static Timer HexEditorTimer;

        //Values
        public static bool isLoaded = false;

        public static CorruptionEngine selectedEngine = CorruptionEngine.NIGHTMARE;

        public static int Intensity = 100;
        public static int StartingAddress = 0;
        public static int BlastRange = 0;
        public static bool useBlastRange = false;
        public static string ProcessHookName = "";

        public static bool ExtractBlastLayer = false;
        public static string lastOpenTarget = null;

        //General Values
        public static string currentDir = System.IO.Directory.GetCurrentDirectory();
        public static string currentTargetType = "";
        public static string currentTargetName = "";
        public static string currentTargetId = "";

        public static bool writeCopyMode = false;
        public static bool AutoUncorrupt = true;

        //Forms
        public static WGH_MainForm ghForm;
        public static WGH_SelectMultiple smForm = null;

        //Object references
        public static MemoryInterface currentMemoryInterface = null;
        public static Stockpile currentStockpile = null;
        public static StashKey currentStashkey = null;
        public static BlastLayer lastBlastLayerBackup = null;
        

        public static void Start(WGH_MainForm _ghForm)
        {

            bool Expires = false;
            DateTime ExpiringDate = DateTime.Parse("2015-01-02");

            if (Expires && DateTime.Now > ExpiringDate)
            {
                MessageBox.Show("This version has expired");
                Application.Exit();
                return;
            }

            ghForm = _ghForm;
            //coreForm.Show();
            //RTC_RPC.Start();

        }

        public static long LongRandom(long max)
        {
            return LongRandom(0, max);
        }

        public static long LongRandom(long min, long max)
        {
            if (max > 2147483647)
            {
                /*
            byte[] buf = new byte[8];
            RND.NextBytes(buf);
            long longRand = BitConverter.ToInt64(buf, 0);

            return (Math.Abs(longRand % (max - min)) + min);
                 * */
                return (long)RND.Next((int)min, 2147483647);

            }
            else
                return (long)RND.Next((int)min, (int)max);
        }

        public static BlastUnit getBlastUnit(string _target, long _address)
        {

            BlastUnit bu = null;

            switch (selectedEngine)
            {
                case CorruptionEngine.NIGHTMARE:
                    bu = WGH_NightmareEngine.GenerateUnit(_target, _address);
                    break;
                case CorruptionEngine.DOT:
                    //bu = WGH_DotEngine.GenerateUnit(_target, _address);
                    break;
                case CorruptionEngine.PATCH:
                    //bu = WGH_PatchEngine.GenerateUnit(_target, _address);
                    break;
                case CorruptionEngine.NONE:
                    return null;
            }

            return bu;
        }

        //Generates or queries a blast layer then applies it.
        public static BlastLayer Blast(BlastLayer _layer)
        {
            try
            {
                if (_layer != null)
                {
                    _layer.Apply(); //If the BlastLayer was provided, there's no need to generate a new one.

                    currentMemoryInterface.ApplyWorkingFile();

                    return _layer;
                }
                else
                {
                    BlastLayer bl = new BlastLayer();

                    string TargetType;
                    long StartingAddress;
                    long BlastRange;
                    long MaxAddress;
                    long RandomAdress = 0;
                    BlastUnit bu;

                    TargetType = currentTargetType;
                    StartingAddress = WGH_Core.StartingAddress;
                    BlastRange = WGH_Core.BlastRange;
                    MaxAddress = (int)currentMemoryInterface.lastMemorySize;

                    if (!WGH_Core.useBlastRange)
                        BlastRange = MaxAddress - StartingAddress;
                    else if (StartingAddress + BlastRange > MaxAddress)
                        BlastRange = MaxAddress - StartingAddress;



                    for (int i = 0; i < Intensity; i++)
                    {
                        RandomAdress = StartingAddress + LongRandom(BlastRange);

                        bu = getBlastUnit(TargetType, RandomAdress);
                        if (bu != null)
                            bl.Layer.Add(bu);
                    }

                    bl.Apply();

                    currentMemoryInterface.ApplyWorkingFile();

                    if (bl.Layer.Count == 0)
                        return null;
                    else
                        return bl;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong in the WGH Core. \n\n" +
                ex.ToString());
                return null;
            }
        }

        public static BlastLayer Blast()
        {
            return Blast(null);
        }

        public static string GetRandomKey()
        {
            string Key = RND.Next(1, 9999).ToString() + RND.Next(1, 9999).ToString() + RND.Next(1, 9999).ToString() + RND.Next(1, 9999).ToString();
            return Key;
        }

        public static void LoadTarget()
        {

            if (WGH_Core.ghForm.rbTargetFile.Checked)
            {
                OpenFileDialog OpenFileDialog1;
                LoadTargetAgain:
                OpenFileDialog1 = new OpenFileDialog();

                OpenFileDialog1.Title = "Open File";
                OpenFileDialog1.Filter = "files|*.*";
                OpenFileDialog1.RestoreDirectory = true;
                if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if(OpenFileDialog1.FileName.ToString().Contains('^'))
                    {
                        MessageBox.Show("You can't use a file that contains the character ^ ");
                        goto LoadTargetAgain;
                    }

                    currentTargetId = "File|" + OpenFileDialog1.FileName.ToString();
                }
                else
                    return;

                if (currentMemoryInterface != null && (currentTargetType == "File" || currentTargetType == "MultipleFiles"))
                    WGH_Core.RestoreTarget();

                currentTargetType = "File";
                var fi = new FileInterface(currentTargetId);
                currentTargetName = fi.shortFilename;
                currentMemoryInterface = fi;
                ghForm.lbTarget.Text = currentTargetId + "|MemorySize:" + fi.lastMemorySize.ToString();

            }
            else if (WGH_Core.ghForm.rbTargetMultipleFiles.Checked)
            {
                if(smForm != null)
                   smForm.Close();

                smForm = new WGH_SelectMultiple();

                if (smForm.ShowDialog() != DialogResult.OK)
                {
                    WGH_Core.currentMemoryInterface = null;
                    return;
                }

                currentTargetType = "MultipleFiles";
                var mfi = (MultipleFileInterface)WGH_Core.currentMemoryInterface;
                currentTargetName = mfi.shortFilename;
                ghForm.lbTarget.Text = mfi.shortFilename + "|MemorySize:" + mfi.lastMemorySize.ToString();
            }
            else if (WGH_Core.ghForm.rbTargetProcess.Checked)
            {
                currentMemoryInterface = new ProcessInterface(currentTargetId);
            }
        }

        public static void RestoreTarget()
        {
            if (WGH_Core.AutoUncorrupt)
            {
                if (WGH_Core.lastBlastLayerBackup != null)
                    WGH_Core.lastBlastLayerBackup.Apply();
                else
                {
                    //CHECK CRC WITH BACKUP HERE AND SKIP BACKUP IF WORKING FILE = BACKUP FILE
                    WGH_Core.currentMemoryInterface.ResetWorkingFile();
                }
            }
            else
            {
                WGH_Core.currentMemoryInterface.ResetWorkingFile();
            }
        }

    }
}
