using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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
            multiTrackBar_Comp1.registerSlave(multiTrackBar_Comp3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            multiTrackBar_Comp1.Maximum = Convert.ToInt64(textBox1.Text);
        }
    }
}
