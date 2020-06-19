namespace DesktopAssistant.app.task
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
            this.progress = new System.Windows.Forms.Label();
            this.endTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // describe
            // 
            this.describe.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.describe.AutoSize = true;
            this.describe.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.describe.ForeColor = System.Drawing.Color.Indigo;
            this.describe.Location = new System.Drawing.Point(19, 15);
            this.describe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.describe.Name = "describe";
            this.describe.Size = new System.Drawing.Size(84, 19);
            this.describe.TabIndex = 3;
            this.describe.Text = "啥啥ddl";
            this.describe.Click += new System.EventHandler(this.label3_Click);
            // 
            // progress
            // 
            this.progress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.progress.AutoSize = true;
            this.progress.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.progress.ForeColor = System.Drawing.Color.Crimson;
            this.progress.Location = new System.Drawing.Point(21, 42);
            this.progress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(154, 14);
            this.progress.TabIndex = 4;
            this.progress.Text = "进度：20%（颜色会变）";
            // 
            // endTime
            // 
            this.endTime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.endTime.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.endTime.ForeColor = System.Drawing.Color.BlueViolet;
            this.endTime.Location = new System.Drawing.Point(284, 27);
            this.endTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.endTime.Name = "endTime";
            this.endTime.Size = new System.Drawing.Size(92, 16);
            this.endTime.TabIndex = 5;
            this.endTime.Text = "x月x日x时";
            // 
            // TaskEach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.endTime);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.describe);
            this.DoubleBuffered = true;
            this.Name = "TaskEach";
            this.Size = new System.Drawing.Size(388, 68);
            this.Load += new System.EventHandler(this.Task_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label describe;
        private System.Windows.Forms.Label progress;
        private System.Windows.Forms.Label endTime;
    }
}
