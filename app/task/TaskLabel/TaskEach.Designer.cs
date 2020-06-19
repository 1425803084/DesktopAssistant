namespace DesktopAssistant.app.task.TaskLabel
{
    partial class TaskEach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskEach));
            this.describe = new System.Windows.Forms.Label();
            this.endTime = new System.Windows.Forms.Label();
            this.progress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // describe
            // 
            this.describe.AutoSize = true;
            this.describe.Font = new System.Drawing.Font("幼圆", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.describe.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.describe.Location = new System.Drawing.Point(19, 14);
            this.describe.Name = "describe";
            this.describe.Size = new System.Drawing.Size(64, 20);
            this.describe.TabIndex = 0;
            this.describe.Text = "XXDDL";
            this.describe.Click += new System.EventHandler(this.label1_Click);
            // 
            // endTime
            // 
            this.endTime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.endTime.AutoSize = true;
            this.endTime.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.endTime.ForeColor = System.Drawing.Color.MidnightBlue;
            this.endTime.Location = new System.Drawing.Point(177, 28);
            this.endTime.Name = "endTime";
            this.endTime.Size = new System.Drawing.Size(135, 19);
            this.endTime.TabIndex = 1;
            this.endTime.Text = "xx月xx日xx时";
            // 
            // progress
            // 
            this.progress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.progress.AutoSize = true;
            this.progress.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.progress.ForeColor = System.Drawing.Color.Firebrick;
            this.progress.Location = new System.Drawing.Point(19, 42);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(70, 14);
            this.progress.TabIndex = 2;
            this.progress.Text = "进度：20%";
            this.progress.Click += new System.EventHandler(this.label3_Click);
            // 
            // TaskEach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.progress);
            this.Controls.Add(this.endTime);
            this.Controls.Add(this.describe);
            this.DoubleBuffered = true;
            this.Name = "TaskEach";
            this.Size = new System.Drawing.Size(324, 70);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label describe;
        public System.Windows.Forms.Label endTime;
        public System.Windows.Forms.Label progress;
    }
}
