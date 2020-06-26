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
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 36);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.frmTopMost_DoubleClick);
            // 
            // ToMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(116, 36);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ToMain";
            this.Opacity = 0.2D;
            this.Text = "ToMain";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private void Form3_Load(object sender, System.EventArgs e)

        {

            this.Show();



            // Init window size and position

            this.Top = pParent.Top + 69;
            this.Left = pParent.Left + 247;



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

        private System.Windows.Forms.Button button1;
    }
}