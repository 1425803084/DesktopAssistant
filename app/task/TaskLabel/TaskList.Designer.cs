namespace DesktopAssistant.app.task
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
            this.task1 = new DesktopAssistant.app.task.TaskEach();
            this.SuspendLayout();
            // 
            // task1
            // 
            this.task1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.task1.BackColor = System.Drawing.Color.Transparent;
            this.task1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("task1.BackgroundImage")));
            this.task1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.task1.Location = new System.Drawing.Point(10, 12);
            this.task1.Margin = new System.Windows.Forms.Padding(5);
            this.task1.Name = "task1";
            this.task1.Size = new System.Drawing.Size(385, 70);
            this.task1.TabIndex = 0;
            // 
            // TaskList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.task1);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "TaskList";
            this.Size = new System.Drawing.Size(406, 591);
            this.Load += new System.EventHandler(this.TaskList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private TaskEach task1;
    }
}
