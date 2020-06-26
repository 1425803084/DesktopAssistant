namespace DesktopAssistant.app.task.TaskDetail
{
    partial class TagEach
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
            this.image = new System.Windows.Forms.Panel();
            this.tagName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // image
            // 
            this.image.BackColor = System.Drawing.Color.IndianRed;
            this.image.Location = new System.Drawing.Point(19, 15);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(15, 15);
            this.image.TabIndex = 0;
            // 
            // tagName
            // 
            this.tagName.AutoSize = true;
            this.tagName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tagName.Location = new System.Drawing.Point(44, 12);
            this.tagName.Name = "tagName";
            this.tagName.Size = new System.Drawing.Size(42, 21);
            this.tagName.TabIndex = 1;
            this.tagName.Text = "学习";
            this.tagName.BackColor = System.Drawing.Color.Transparent;
            this.tagName.Click += new System.EventHandler(this.tagName_Click);
            // 
            // TagEach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::DesktopAssistant.Properties.Resources.TagBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.tagName);
            this.Controls.Add(this.image);
            this.DoubleBuffered = true;
            this.Name = "TagEach";
            this.Size = new System.Drawing.Size(250, 45);
            this.MouseLeave += new System.EventHandler(this.TagEach_MouseLeave);
            this.MouseHover += new System.EventHandler(this.TagEach_MouseHover);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel image;
        public System.Windows.Forms.Label tagName;
    }
}
