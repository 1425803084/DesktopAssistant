namespace DesktopAssistant.app.task.TaskLabel
{
    partial class TaskAddNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskAddNew));
            this.textBox = new System.Windows.Forms.TextBox();
            this.hintImage = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(152)))), ((int)(((byte)(190)))));
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox.ForeColor = System.Drawing.Color.White;
            this.textBox.Location = new System.Drawing.Point(53, 18);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(383, 22);
            this.textBox.TabIndex = 3;
            // 
            // hintImage
            // 
            this.hintImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.hintImage.BackColor = System.Drawing.Color.Transparent;
            this.hintImage.BackgroundImage = global::DesktopAssistant.Properties.Resources.Add;
            this.hintImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hintImage.Location = new System.Drawing.Point(20, 16);
            this.hintImage.Name = "hintImage";
            this.hintImage.Size = new System.Drawing.Size(24, 24);
            this.hintImage.TabIndex = 4;
            // 
            // TaskAddNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.hintImage);
            this.Controls.Add(this.textBox);
            this.DoubleBuffered = true;
            this.Name = "TaskAddNew";
            this.Size = new System.Drawing.Size(471, 55);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textBox;
        public System.Windows.Forms.Panel hintImage;
    }
}
