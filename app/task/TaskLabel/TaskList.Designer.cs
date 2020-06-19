namespace DesktopAssistant.app.task.TaskLabel
{
    partial class TaskList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskList));
            this.taskEach1 = new DesktopAssistant.app.task.TaskLabel.TaskEach();
            this.SuspendLayout();
            // 
            // taskEach1
            // 
            this.taskEach1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taskEach1.BackColor = System.Drawing.Color.Transparent;
            this.taskEach1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("taskEach1.BackgroundImage")));
            this.taskEach1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.taskEach1.Location = new System.Drawing.Point(10, 12);
            this.taskEach1.Name = "taskEach1";
            this.taskEach1.Size = new System.Drawing.Size(335, 64);
            this.taskEach1.TabIndex = 0;
            // 
            // TaskList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.taskEach1);
            this.Name = "TaskList";
            this.Size = new System.Drawing.Size(356, 524);
            this.ResumeLayout(false);

        }

        #endregion

        public TaskEach taskEach1;
    }
}
