namespace DesktopAssistant.app.menu
{
    partial class MainMenu
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuName = new System.Windows.Forms.Label();
            this.hint = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Image = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // MenuName
            // 
            this.MenuName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MenuName.AutoSize = true;
            this.MenuName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MenuName.Location = new System.Drawing.Point(55, 15);
            this.MenuName.Name = "MenuName";
            this.MenuName.Size = new System.Drawing.Size(74, 21);
            this.MenuName.TabIndex = 1;
            this.MenuName.Text = "我的一天";
            // 
            // hint
            // 
            this.hint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hint.AutoSize = true;
            this.hint.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.hint.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.hint.Location = new System.Drawing.Point(284, 15);
            this.hint.Name = "hint";
            this.hint.Size = new System.Drawing.Size(17, 20);
            this.hint.TabIndex = 2;
            this.hint.Text = "3";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(4, 41);
            this.panel1.TabIndex = 3;
            // 
            // Image
            // 
            this.Image.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Image.BackColor = System.Drawing.Color.Transparent;
            this.Image.BackgroundImage = global::DesktopAssistant.Properties.Resources.sun;
            this.Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Image.Location = new System.Drawing.Point(20, 13);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(26, 27);
            this.Image.TabIndex = 0;
            this.Image.Paint += new System.Windows.Forms.PaintEventHandler(this.Image_Paint);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.hint);
            this.Controls.Add(this.MenuName);
            this.Controls.Add(this.Image);
            this.Name = "MainMenu";
            this.Size = new System.Drawing.Size(320, 48);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Image;
        private System.Windows.Forms.Label MenuName;
        private System.Windows.Forms.Label hint;
        private System.Windows.Forms.Panel panel1;
    }
}
