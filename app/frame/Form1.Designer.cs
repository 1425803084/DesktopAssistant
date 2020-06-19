namespace DesktopAssistant.app.frame
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tomatoTimer1 = new DesktopAssistant.app.tomato.TomatoTimer();
            this.SuspendLayout();
            // 
            // tomatoTimer1
            // 
            this.tomatoTimer1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tomatoTimer1.BackgroundImage")));
            this.tomatoTimer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tomatoTimer1.Location = new System.Drawing.Point(0, 3);
            this.tomatoTimer1.Name = "tomatoTimer1";
            this.tomatoTimer1.Size = new System.Drawing.Size(457, 702);
            this.tomatoTimer1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 705);
            this.Controls.Add(this.tomatoTimer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private tomato.TomatoTimer tomatoTimer1;
    }
}