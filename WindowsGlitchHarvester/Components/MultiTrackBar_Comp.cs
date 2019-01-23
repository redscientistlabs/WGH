using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsGlitchHarvester.Components
{
    public partial class MultiTrackBar_Comp : UserControl
    {
        bool GeneralUpdateFlag = false; //makes other events ignore firing

        public List<MultiTrackBar_Comp> slaveComps = new List<MultiTrackBar_Comp>();
        public MultiTrackBar_Comp parentComp = null;

        public MultiTrackBar_Comp()
        {
            InitializeComponent();
        }

        internal void registerSlave(MultiTrackBar_Comp comp)
        {
            slaveComps.Add(comp);
            comp.parentComp = this;

        }

        private void MultiTrackBar_Comp_Load(object sender, EventArgs e)
        {
        }

        public void UpdateAllControls(long value, Control setter)
        {
            GeneralUpdateFlag = true;

            if (setter != this)
            {

                if (setter != tbControlValue)
                {
                    if (value > 65536)
                        tbControlValue.Value = 65536;
                    else
                        tbControlValue.Value = Convert.ToInt32(value);
                }

                if (setter != nmControlValue)
                    nmControlValue.Value = value;



                foreach (var slave in slaveComps)
                    slave.UpdateAllControls(value, this);

                if (parentComp != null)
                    parentComp.UpdateAllControls(value, setter);

            }

            GeneralUpdateFlag = false;
        }

        public void PropagateValue(long value, Control setter)
        {
            UpdateAllControls(value, setter);

            //call event whatever
        }

        private void nmControlValue_KeyUp(object sender, KeyEventArgs e)
        {
            if (GeneralUpdateFlag)
                return;

            PropagateValue(Convert.ToInt64(nmControlValue.Value), nmControlValue);
        }

        private void tbControlValue_MouseUp(object sender, MouseEventArgs e)
        {
            if (GeneralUpdateFlag)
                return;

            PropagateValue(tbControlValue.Value, tbControlValue);
        }

        private void tbControlValue_ValueChanged(object sender, EventArgs e)
        {
            if (GeneralUpdateFlag)
                return;

            UpdateAllControls(tbControlValue.Value, tbControlValue);
        }

        private void nmControlValue_ValueChanged(object sender, EventArgs e)
        {
            if (GeneralUpdateFlag)
                return;

            UpdateAllControls(Convert.ToInt64(nmControlValue.Value), nmControlValue);
        }
    }

    internal class NoFocusTrackBar : System.Windows.Forms.TrackBar
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public extern static int SendMessage(IntPtr hWnd, uint msg, int wParam, int lParam);

        private static int MakeParam(int loWord, int hiWord)
        {
            return (hiWord << 16) | (loWord & 0xffff);
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            SendMessage(this.Handle, 0x0128, MakeParam(1, 0x1), 0);
        }
    }
}
