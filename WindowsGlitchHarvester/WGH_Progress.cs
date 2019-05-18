using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsGlitchHarvester
{
    public partial class WGH_Progress : Form
    {
        public BackgroundWorker bw = new BackgroundWorker();
        string defaultLabel;

        public static Action<object> postAction = null;

        public Action<object> newActionRegistrant = null;

        public WGH_Progress(string lbText, int maxprogress, Action<object> actionRegistrant, Action<object> postActionRegistrant = null)
        {
            InitializeComponent();

            BackColor = WGH_Core.ghForm.BackColor;

            bw.WorkerReportsProgress = true;
            bw.WorkerSupportsCancellation = true;

            defaultLabel = lbText;
            lbProgress.Text = defaultLabel;

            pbProgress.Minimum = 0;
            pbProgress.Value = 0;
            pbProgress.Maximum = maxprogress;

            bw.DoWork += Bw_DoWork;
            //bw.DoWork += actionRegistrant.Invoke;
            newActionRegistrant = actionRegistrant;
            bw.ProgressChanged += Bw_ProgressChanged;
            bw.RunWorkerCompleted += Bw_RunWorkerCompleted;

            postAction = postActionRegistrant;

            TopLevel = false;
            Size = WGH_Core.ghForm.Size;

            WGH_Core.ghForm.Controls.Add(this);
            Anchor = (AnchorStyles)(AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom);
            Show();
            BringToFront();



        }

        private void Bw_DoWork(object sender, DoWorkEventArgs e)
        {
            newActionRegistrant.Invoke(sender);
        }

        public void Run()
        {
            bw.RunWorkerAsync();
        }

        private void Bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bw.Dispose();
            this.Hide();
            WGH_Core.progressForm = null;

            if (postAction != null)
            {
                WGH_Core.FormExecute((o) => {
                    postAction.Invoke(null);
                });
            }
                
        }

        private void Bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage != 0)
            {
                if (pbProgress.Value + 1000 < pbProgress.Maximum)
                    pbProgress.Value += 1000;
                else
                    pbProgress.Value = pbProgress.Maximum;
            }

            if (e.UserState != null && e.UserState is string)
            {
                if((e.UserState as string) == "DEFAULT")
                    lbProgress.Text = defaultLabel;
                else
                    lbProgress.Text = (e.UserState as string);
            }

        }

    }
}
