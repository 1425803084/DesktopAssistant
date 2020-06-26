namespace DesktopAssistant.app.TaskDetail
{
    partial class Taskdetail
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
            this.timePanel = new System.Windows.Forms.Panel();
            this.timeLabel = new System.Windows.Forms.Label();
            this.tagPanel = new System.Windows.Forms.Panel();
            this.tagLabel = new System.Windows.Forms.Label();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.tagSelectList = new DesktopAssistant.app.task.TaskDetail.TagSelectList();
            this.progressBar = new DesktopAssistant.app.task.TaskDetail.ProgressBar();
            this.taskTextBox1 = new DesktopAssistant.app.task.TaskDetail.TaskTextBox();
            this.taskNameAndSelect = new DesktopAssistant.app.task.TaskDetail.TaskNameAndSelect();
            this.delete = new System.Windows.Forms.Panel();
            this.back = new System.Windows.Forms.Panel();
            this.tagDelete = new System.Windows.Forms.Panel();
            this.tagImage = new System.Windows.Forms.Panel();
            this.timeDelete = new System.Windows.Forms.Panel();
            this.timeImage = new System.Windows.Forms.Panel();
            this.timePanel.SuspendLayout();
            this.tagPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // timePanel
            // 
            this.timePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timePanel.BackColor = System.Drawing.Color.White;
            this.timePanel.Controls.Add(this.timeDelete);
            this.timePanel.Controls.Add(this.timeImage);
            this.timePanel.Controls.Add(this.timeLabel);
            this.timePanel.Location = new System.Drawing.Point(9, 138);
            this.timePanel.Name = "timePanel";
            this.timePanel.Size = new System.Drawing.Size(349, 51);
            this.timePanel.TabIndex = 35;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.timeLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.timeLabel.Location = new System.Drawing.Point(49, 15);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(106, 21);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.Text = "添加截止时间";
            this.timeLabel.Click += new System.EventHandler(this.timeLabel_Click);
            // 
            // tagPanel
            // 
            this.tagPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tagPanel.BackColor = System.Drawing.Color.White;
            this.tagPanel.Controls.Add(this.tagDelete);
            this.tagPanel.Controls.Add(this.tagImage);
            this.tagPanel.Controls.Add(this.tagLabel);
            this.tagPanel.Location = new System.Drawing.Point(9, 188);
            this.tagPanel.Name = "tagPanel";
            this.tagPanel.Size = new System.Drawing.Size(349, 51);
            this.tagPanel.TabIndex = 36;
            // 
            // tagLabel
            // 
            this.tagLabel.AutoSize = true;
            this.tagLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tagLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tagLabel.Location = new System.Drawing.Point(49, 17);
            this.tagLabel.Name = "tagLabel";
            this.tagLabel.Size = new System.Drawing.Size(106, 21);
            this.tagLabel.TabIndex = 0;
            this.tagLabel.Text = "添加任务标记";
            // 
            // bottomPanel
            // 
            this.bottomPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bottomPanel.BackColor = System.Drawing.Color.White;
            this.bottomPanel.Controls.Add(this.delete);
            this.bottomPanel.Controls.Add(this.back);
            this.bottomPanel.Location = new System.Drawing.Point(0, 738);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(366, 58);
            this.bottomPanel.TabIndex = 37;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.monthCalendar1.Location = new System.Drawing.Point(79, 188);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 38;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // tagSelectList
            // 
            this.tagSelectList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tagSelectList.AutoScroll = true;
            this.tagSelectList.AutoScrollMinSize = new System.Drawing.Size(200, 0);
            this.tagSelectList.BackColor = System.Drawing.Color.Transparent;
            this.tagSelectList.Enabled = false;
            this.tagSelectList.Location = new System.Drawing.Point(59, 244);
            this.tagSelectList.Name = "tagSelectList";
            this.tagSelectList.Size = new System.Drawing.Size(250, 208);
            this.tagSelectList.TabIndex = 40;
            this.tagSelectList.Visible = false;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.BackColor = System.Drawing.Color.White;
            this.progressBar.Location = new System.Drawing.Point(9, 69);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(349, 51);
            this.progressBar.TabIndex = 39;
            // 
            // taskTextBox1
            // 
            this.taskTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taskTextBox1.BackColor = System.Drawing.Color.White;
            this.taskTextBox1.Location = new System.Drawing.Point(9, 256);
            this.taskTextBox1.Name = "taskTextBox1";
            this.taskTextBox1.Size = new System.Drawing.Size(349, 105);
            this.taskTextBox1.TabIndex = 33;
            // 
            // taskNameAndSelect
            // 
            this.taskNameAndSelect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taskNameAndSelect.BackColor = System.Drawing.Color.White;
            this.taskNameAndSelect.Location = new System.Drawing.Point(0, 0);
            this.taskNameAndSelect.Name = "taskNameAndSelect";
            this.taskNameAndSelect.Size = new System.Drawing.Size(366, 58);
            this.taskNameAndSelect.TabIndex = 31;
            // 
            // delete
            // 
            this.delete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.delete.BackgroundImage = global::DesktopAssistant.Properties.Resources.rubbishBin;
            this.delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delete.Location = new System.Drawing.Point(314, 0);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(52, 58);
            this.delete.TabIndex = 1;
            // 
            // back
            // 
            this.back.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.back.BackgroundImage = global::DesktopAssistant.Properties.Resources.back;
            this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back.Location = new System.Drawing.Point(0, 0);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(55, 58);
            this.back.TabIndex = 0;
            // 
            // tagDelete
            // 
            this.tagDelete.BackgroundImage = global::DesktopAssistant.Properties.Resources.delete;
            this.tagDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tagDelete.Location = new System.Drawing.Point(305, 0);
            this.tagDelete.Name = "tagDelete";
            this.tagDelete.Size = new System.Drawing.Size(44, 51);
            this.tagDelete.TabIndex = 4;
            this.tagDelete.Click += new System.EventHandler(this.tagDelete_Click);
            // 
            // tagImage
            // 
            this.tagImage.BackColor = System.Drawing.Color.Transparent;
            this.tagImage.BackgroundImage = global::DesktopAssistant.Properties.Resources.eglass_tag;
            this.tagImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tagImage.Location = new System.Drawing.Point(14, 15);
            this.tagImage.Name = "tagImage";
            this.tagImage.Size = new System.Drawing.Size(27, 26);
            this.tagImage.TabIndex = 3;
            // 
            // timeDelete
            // 
            this.timeDelete.BackgroundImage = global::DesktopAssistant.Properties.Resources.delete;
            this.timeDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.timeDelete.Location = new System.Drawing.Point(305, 0);
            this.timeDelete.Name = "timeDelete";
            this.timeDelete.Size = new System.Drawing.Size(44, 51);
            this.timeDelete.TabIndex = 0;
            this.timeDelete.Click += new System.EventHandler(this.timeDelete_Click);
            // 
            // timeImage
            // 
            this.timeImage.BackColor = System.Drawing.Color.Transparent;
            this.timeImage.BackgroundImage = global::DesktopAssistant.Properties.Resources.canlender_defalut;
            this.timeImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.timeImage.Location = new System.Drawing.Point(12, 13);
            this.timeImage.Name = "timeImage";
            this.timeImage.Size = new System.Drawing.Size(28, 26);
            this.timeImage.TabIndex = 2;
            // 
            // Taskdetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.tagSelectList);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.tagPanel);
            this.Controls.Add(this.timePanel);
            this.Controls.Add(this.taskTextBox1);
            this.Controls.Add(this.taskNameAndSelect);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(340, 0);
            this.Name = "Taskdetail";
            this.Size = new System.Drawing.Size(366, 796);
            this.timePanel.ResumeLayout(false);
            this.timePanel.PerformLayout();
            this.tagPanel.ResumeLayout(false);
            this.tagPanel.PerformLayout();
            this.bottomPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public task.TaskDetail.TaskNameAndSelect taskNameAndSelect;
        public task.TaskDetail.TaskTextBox taskTextBox1;
        public System.Windows.Forms.Panel timePanel;
        public System.Windows.Forms.Label timeLabel;
        public System.Windows.Forms.Panel tagPanel;
        public System.Windows.Forms.Label tagLabel;
        public System.Windows.Forms.Panel bottomPanel;
        public System.Windows.Forms.MonthCalendar monthCalendar1;
        public task.TaskDetail.ProgressBar progressBar;
        public task.TaskDetail.TagSelectList tagSelectList;
        public System.Windows.Forms.Panel timeImage;
        public System.Windows.Forms.Panel tagImage;
        public System.Windows.Forms.Panel timeDelete;
        public System.Windows.Forms.Panel tagDelete;
        public System.Windows.Forms.Panel delete;
        public System.Windows.Forms.Panel back;
    }
}
