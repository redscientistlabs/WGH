using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsGlitchHarvester
{
    public partial class WGH_TestForm : Form
    {
        public WGH_TestForm()
        {
            InitializeComponent();
        }

        private void WGH_TestForm_Load(object sender, EventArgs e)
        {
            multiTrackBar_Comp1.registerSlave(multiTrackBar_Comp2);
        }
    }
}
