namespace WindowsGlitchHarvester
{
    partial class WGH_TestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.multiTrackBar_Comp3 = new WindowsGlitchHarvester.Components.MultiTrackBar_Comp();
            this.multiTrackBar_Comp2 = new WindowsGlitchHarvester.Components.MultiTrackBar_Comp();
            this.multiTrackBar_Comp1 = new WindowsGlitchHarvester.Components.MultiTrackBar_Comp();
            this.SuspendLayout();
            // 
            // multiTrackBar_Comp3
            // 
            this.multiTrackBar_Comp3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.multiTrackBar_Comp3.Location = new System.Drawing.Point(30, 226);
            this.multiTrackBar_Comp3.Name = "multiTrackBar_Comp3";
            this.multiTrackBar_Comp3.Size = new System.Drawing.Size(334, 63);
            this.multiTrackBar_Comp3.TabIndex = 2;
            this.multiTrackBar_Comp3.Tag = "color:darker";
            // 
            // multiTrackBar_Comp2
            // 
            this.multiTrackBar_Comp2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.multiTrackBar_Comp2.Location = new System.Drawing.Point(30, 128);
            this.multiTrackBar_Comp2.Name = "multiTrackBar_Comp2";
            this.multiTrackBar_Comp2.Size = new System.Drawing.Size(334, 63);
            this.multiTrackBar_Comp2.TabIndex = 1;
            this.multiTrackBar_Comp2.Tag = "color:darker";
            // 
            // multiTrackBar_Comp1
            // 
            this.multiTrackBar_Comp1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.multiTrackBar_Comp1.Location = new System.Drawing.Point(30, 25);
            this.multiTrackBar_Comp1.Name = "multiTrackBar_Comp1";
            this.multiTrackBar_Comp1.Size = new System.Drawing.Size(334, 63);
            this.multiTrackBar_Comp1.TabIndex = 0;
            this.multiTrackBar_Comp1.Tag = "color:darker";
            // 
            // WGH_TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(506, 330);
            this.Controls.Add(this.multiTrackBar_Comp3);
            this.Controls.Add(this.multiTrackBar_Comp2);
            this.Controls.Add(this.multiTrackBar_Comp1);
            this.Name = "WGH_TestForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.WGH_TestForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Components.MultiTrackBar_Comp multiTrackBar_Comp1;
        private Components.MultiTrackBar_Comp multiTrackBar_Comp2;
        private Components.MultiTrackBar_Comp multiTrackBar_Comp3;
    }
}