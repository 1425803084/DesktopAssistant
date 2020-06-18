namespace DesktopAssistant.app.task
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
            this.add1 = new DesktopAssistant.app.controls.Add();
            this.taskList1 = new DesktopAssistant.app.task.TaskList();
            this.dataText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // add1
            // 
            this.add1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.add1.BackColor = System.Drawing.Color.Transparent;
            this.add1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add1.BackgroundImage")));
            this.add1.Location = new System.Drawing.Point(6, 559);
            this.add1.Margin = new System.Windows.Forms.Padding(2);
            this.add1.Name = "add1";
            this.add1.Size = new System.Drawing.Size(143, 51);
            this.add1.TabIndex = 2;
            // 
            // taskList1
            // 
            this.taskList1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taskList1.AutoScroll = true;
            this.taskList1.BackColor = System.Drawing.Color.Transparent;
            this.taskList1.Location = new System.Drawing.Point(10, 100);
            this.taskList1.Margin = new System.Windows.Forms.Padding(10);
            this.taskList1.Name = "taskList1";
            this.taskList1.Size = new System.Drawing.Size(366, 517);
            this.taskList1.TabIndex = 0;
            this.taskList1.Load += new System.EventHandler(this.taskList1_Load);
            // 
            // dataText
            // 
            this.dataText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataText.BackColor = System.Drawing.Color.Transparent;
            this.dataText.Font = new System.Drawing.Font("方正清刻本悦宋简体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataText.ForeColor = System.Drawing.Color.SlateGray;
            this.dataText.Location = new System.Drawing.Point(250, 22);
            this.dataText.Name = "dataText";
            this.dataText.Size = new System.Drawing.Size(126, 35);
            this.dataText.TabIndex = 3;
            this.dataText.Text = "xx月xx日";
            this.dataText.Click += new System.EventHandler(this.label1_Click);
            // 
            // TaskLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.dataText);
            this.Controls.Add(this.add1);
            this.Controls.Add(this.taskList1);
            this.DoubleBuffered = true;
            this.Name = "TaskLabel";
            this.Size = new System.Drawing.Size(386, 627);
            this.Load += new System.EventHandler(this.TaskLabel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private TaskList taskList1;
        private controls.Add add1;
        private System.Windows.Forms.Label dataText;
    }
}
