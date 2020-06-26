namespace DesktopAssistant.app.task.TaskLabel
{
    partial class TaskLabel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskLabel));
            this.timeText = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.taskAddNew = new DesktopAssistant.app.task.TaskLabel.TaskAddNew();
            this.taskList1 = new DesktopAssistant.app.task.TaskLabel.TaskList();
            this.SuspendLayout();
            // 
            // timeText
            // 
            this.timeText.AutoSize = true;
            this.timeText.BackColor = System.Drawing.Color.Transparent;
            this.timeText.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.timeText.ForeColor = System.Drawing.Color.White;
            this.timeText.Location = new System.Drawing.Point(33, 71);
            this.timeText.Name = "timeText";
            this.timeText.Size = new System.Drawing.Size(109, 20);
            this.timeText.TabIndex = 2;
            this.timeText.Text = "xx月xx日, 星期X";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(529, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "置于底部";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "我的一天";
            // 
            // taskAddNew
            // 
            this.taskAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taskAddNew.BackColor = System.Drawing.Color.Transparent;
            this.taskAddNew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("taskAddNew.BackgroundImage")));
            this.taskAddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.taskAddNew.Location = new System.Drawing.Point(37, 759);
            this.taskAddNew.Name = "taskAddNew";
            this.taskAddNew.Size = new System.Drawing.Size(524, 55);
            this.taskAddNew.TabIndex = 7;
            // 
            // taskList1
            // 
            this.taskList1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taskList1.BackColor = System.Drawing.Color.Transparent;
            this.taskList1.Location = new System.Drawing.Point(37, 105);
            this.taskList1.Name = "taskList1";
            this.taskList1.Size = new System.Drawing.Size(524, 631);
            this.taskList1.TabIndex = 4;
            // 
            // TaskLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DesktopAssistant.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.taskAddNew);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.taskList1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.timeText);
            this.DoubleBuffered = true;
            this.Name = "TaskLabel";
            this.Size = new System.Drawing.Size(594, 837);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label timeText;
        public System.Windows.Forms.Button button1;
        public TaskList taskList1;
        public System.Windows.Forms.Label label1;
        public TaskAddNew taskAddNew;
    }
}
