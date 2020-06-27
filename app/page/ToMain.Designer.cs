using DesktopAssistant.app.frame;
using System.Drawing;

namespace DesktopAssistant.app.page
{
    partial class ToMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private suspensionFrame pParent;
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

        public ToMain(suspensionFrame form)
        {
            InitializeComponent();
            pParent = form;

            this.Size = this.pParent.taskPage1.taskLabel.button1.Size;

        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ToMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(194)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(31, 28);
            this.Size = new System.Drawing.Size(31, 28);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ToMain";
            this.Opacity = 0.3D;
            this.Text = "ToMain";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.Click += new System.EventHandler(this.frmTopMost_DoubleClick);
            this.ResumeLayout(false);

        }

        #endregion

        private void Form3_Load(object sender, System.EventArgs e)

        {

            this.Show();

            // Init window size and position
            //this.Top = pParent.Top + 50;
            //this.Left = pParent.Left + 247;
            this.ClientSize = this.pParent.taskPage1.taskLabel.button1.Size;
            this.Size = this.pParent.taskPage1.taskLabel.button1.Size;
            this.Top = pParent.Top + pParent.taskPage1.taskLabel.button1.Top;
            this.Left = pParent.Left + pParent.taskPage1.taskLabel.button1.Left;
        }

        private void frmTopMost_DoubleClick(object sender, System.EventArgs e)

        {

            SwitchToMain();

        }

        private void SwitchToMain()

        {

            //Change main window status here

            pParent.RestoreWindow();
            pParent.pParent.RestoreWindow();
            pParent.pParent.Visible = true;

            //Hide top most window

            this.Hide();
            this.pParent.Hide();

        }
    }
}