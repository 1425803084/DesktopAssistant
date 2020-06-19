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
            this.taskList1 = new DesktopAssistant.app.task.TaskLabel.TaskList();
            this.add1 = new DesktopAssistant.app.controls.Add();
            this.timeText = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // taskList1
            // 
            this.taskList1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taskList1.BackColor = System.Drawing.Color.Transparent;
            this.taskList1.Location = new System.Drawing.Point(3, 125);
            this.taskList1.Name = "taskList1";
            this.taskList1.Size = new System.Drawing.Size(442, 557);
            this.taskList1.TabIndex = 0;
            // 
            // add1
            // 
            this.add1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.add1.BackColor = System.Drawing.Color.Transparent;
            this.add1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add1.BackgroundImage")));
            this.add1.Location = new System.Drawing.Point(3, 604);
            this.add1.Margin = new System.Windows.Forms.Padding(2);
            this.add1.Name = "add1";
            this.add1.Size = new System.Drawing.Size(139, 56);
            this.add1.TabIndex = 1;
            // 
            // timeText
            // 
            this.timeText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timeText.AutoSize = true;
            this.timeText.BackColor = System.Drawing.Color.Transparent;
            this.timeText.Font = new System.Drawing.Font("方正清刻本悦宋简体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.timeText.Location = new System.Drawing.Point(253, 22);
            this.timeText.Name = "timeText";
            this.timeText.Size = new System.Drawing.Size(174, 32);
            this.timeText.TabIndex = 2;
            this.timeText.Text = "xx月xx日xx时";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(328, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "置于底部";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TaskLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.timeText);
            this.Controls.Add(this.add1);
            this.Controls.Add(this.taskList1);
            this.DoubleBuffered = true;
            this.Name = "TaskLabel";
            this.Size = new System.Drawing.Size(448, 685);
            this.Load += new System.EventHandler(this.TaskLabel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public TaskList taskList1;
        public controls.Add add1;
        public System.Windows.Forms.Label timeText;
        public System.Windows.Forms.Button button1;
    }
}
