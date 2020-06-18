namespace DesktopAssistant.app.frame
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.ListS2 = new System.Windows.Forms.Button();
            this.Tclock = new System.Windows.Forms.Button();
            this.GameM2 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ListS2
            // 
            this.ListS2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ListS2.BackgroundImage")));
            this.ListS2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ListS2.Location = new System.Drawing.Point(-3, 1);
            this.ListS2.Name = "ListS2";
            this.ListS2.Size = new System.Drawing.Size(261, 91);
            this.ListS2.TabIndex = 4;
            this.ListS2.UseVisualStyleBackColor = true;
            // 
            // Tclock
            // 
            this.Tclock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Tclock.BackgroundImage")));
            this.Tclock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Tclock.Location = new System.Drawing.Point(255, 1);
            this.Tclock.Name = "Tclock";
            this.Tclock.Size = new System.Drawing.Size(261, 91);
            this.Tclock.TabIndex = 5;
            this.Tclock.UseVisualStyleBackColor = true;
            // 
            // GameM2
            // 
            this.GameM2.AutoSize = true;
            this.GameM2.BackColor = System.Drawing.Color.Transparent;
            this.GameM2.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GameM2.ForeColor = System.Drawing.Color.SlateBlue;
            this.GameM2.Location = new System.Drawing.Point(528, 54);
            this.GameM2.Name = "GameM2";
            this.GameM2.Size = new System.Drawing.Size(115, 24);
            this.GameM2.TabIndex = 7;
            this.GameM2.Text = "游戏监管";
            this.GameM2.UseVisualStyleBackColor = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(653, 90);
            this.Controls.Add(this.GameM2);
            this.Controls.Add(this.Tclock);
            this.Controls.Add(this.ListS2);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ListS2;
        private System.Windows.Forms.Button Tclock;
        private System.Windows.Forms.CheckBox GameM2;
    }
}