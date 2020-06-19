namespace DesktopAssistant.app.TaskDetail
{
    partial class taskdetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(taskdetail));
            this.ddlTime = new System.Windows.Forms.Label();
            this.TSam = new System.Windows.Forms.Label();
            this.TextSammary = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextDetail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tagBox = new System.Windows.Forms.ComboBox();
            this.finish = new System.Windows.Forms.Button();
            this.process = new System.Windows.Forms.Label();
            this.phlTrackBar1 = new PHLTrackBar.PHLTrackBar();
            this.endTimeYear = new System.Windows.Forms.ComboBox();
            this.startTimeMonth = new System.Windows.Forms.ComboBox();
            this.StartTimeDay = new System.Windows.Forms.ComboBox();
            this.startTimeYear = new System.Windows.Forms.ComboBox();
            this.endTimeMonth = new System.Windows.Forms.ComboBox();
            this.endTimeDay = new System.Windows.Forms.ComboBox();
            this.progressRatio = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ddlTime
            // 
            this.ddlTime.AutoSize = true;
            this.ddlTime.BackColor = System.Drawing.Color.Transparent;
            this.ddlTime.Font = new System.Drawing.Font("黑体", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ddlTime.ForeColor = System.Drawing.Color.SlateBlue;
            this.ddlTime.Location = new System.Drawing.Point(12, 23);
            this.ddlTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ddlTime.Name = "ddlTime";
            this.ddlTime.Size = new System.Drawing.Size(46, 22);
            this.ddlTime.TabIndex = 6;
            this.ddlTime.Text = "DDL";
            // 
            // TSam
            // 
            this.TSam.AutoSize = true;
            this.TSam.BackColor = System.Drawing.Color.Transparent;
            this.TSam.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TSam.ForeColor = System.Drawing.Color.BlueViolet;
            this.TSam.Location = new System.Drawing.Point(10, 205);
            this.TSam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TSam.Name = "TSam";
            this.TSam.Size = new System.Drawing.Size(76, 16);
            this.TSam.TabIndex = 10;
            this.TSam.Text = "任务简介";
            // 
            // TextSammary
            // 
            this.TextSammary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextSammary.BackColor = System.Drawing.Color.SeaShell;
            this.TextSammary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextSammary.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextSammary.ForeColor = System.Drawing.Color.BlueViolet;
            this.TextSammary.Location = new System.Drawing.Point(13, 229);
            this.TextSammary.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TextSammary.Name = "TextSammary";
            this.TextSammary.Size = new System.Drawing.Size(297, 19);
            this.TextSammary.TabIndex = 13;
            this.TextSammary.Text = "任务简介";
            this.TextSammary.TextChanged += new System.EventHandler(this.TSammary_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.BlueViolet;
            this.label1.Location = new System.Drawing.Point(9, 262);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "任务详情";
            // 
            // TextDetail
            // 
            this.TextDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextDetail.BackColor = System.Drawing.Color.FloralWhite;
            this.TextDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextDetail.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextDetail.ForeColor = System.Drawing.Color.DarkViolet;
            this.TextDetail.Location = new System.Drawing.Point(13, 284);
            this.TextDetail.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TextDetail.Multiline = true;
            this.TextDetail.Name = "TextDetail";
            this.TextDetail.Size = new System.Drawing.Size(313, 207);
            this.TextDetail.TabIndex = 15;
            this.TextDetail.Text = "任务描述";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.MediumOrchid;
            this.label2.Location = new System.Drawing.Point(11, 524);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tag分类";
            // 
            // tagBox
            // 
            this.tagBox.BackColor = System.Drawing.Color.Thistle;
            this.tagBox.FormattingEnabled = true;
            this.tagBox.Items.AddRange(new object[] {
            "学习",
            "工作",
            "实验",
            "考试"});
            this.tagBox.Location = new System.Drawing.Point(84, 525);
            this.tagBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tagBox.Name = "tagBox";
            this.tagBox.Size = new System.Drawing.Size(92, 20);
            this.tagBox.TabIndex = 17;
            // 
            // finish
            // 
            this.finish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.finish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(194)))), ((int)(((byte)(244)))));
            this.finish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.finish.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.finish.ForeColor = System.Drawing.Color.BlueViolet;
            this.finish.Location = new System.Drawing.Point(217, 576);
            this.finish.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.finish.Name = "finish";
            this.finish.Size = new System.Drawing.Size(106, 41);
            this.finish.TabIndex = 18;
            this.finish.Text = "我已完成";
            this.finish.UseVisualStyleBackColor = false;
            // 
            // process
            // 
            this.process.AutoSize = true;
            this.process.BackColor = System.Drawing.Color.Transparent;
            this.process.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.process.ForeColor = System.Drawing.Color.Crimson;
            this.process.Location = new System.Drawing.Point(13, 135);
            this.process.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.process.Name = "process";
            this.process.Size = new System.Drawing.Size(37, 14);
            this.process.TabIndex = 19;
            this.process.Text = "进度";
            this.process.Click += new System.EventHandler(this.process_Click);
            // 
            // phlTrackBar1
            // 
            this.phlTrackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phlTrackBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(194)))), ((int)(((byte)(244)))));
            this.phlTrackBar1.ForeColor = System.Drawing.Color.Coral;
            this.phlTrackBar1.Location = new System.Drawing.Point(16, 161);
            this.phlTrackBar1.Max = 100;
            this.phlTrackBar1.Min = 0;
            this.phlTrackBar1.Name = "phlTrackBar1";
            this.phlTrackBar1.P_Value = 50;
            this.phlTrackBar1.Progress_Color = System.Drawing.Color.LightSalmon;
            this.phlTrackBar1.ProgressBar_Color = System.Drawing.Color.Silver;
            this.phlTrackBar1.Size = new System.Drawing.Size(304, 15);
            this.phlTrackBar1.T_Value = 50;
            this.phlTrackBar1.TabIndex = 20;
            this.phlTrackBar1.TrackBar_Color = System.Drawing.Color.BlueViolet;
            this.phlTrackBar1.TrackBarVisible = true;
            this.phlTrackBar1.TrackBarWidth = 15;
            this.phlTrackBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.phlTrackBar1_Scroll);
            // 
            // endTimeYear
            // 
            this.endTimeYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.endTimeYear.BackColor = System.Drawing.Color.SeaShell;
            this.endTimeYear.Font = new System.Drawing.Font("黑体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.endTimeYear.ForeColor = System.Drawing.Color.BlueViolet;
            this.endTimeYear.FormattingEnabled = true;
            this.endTimeYear.Items.AddRange(new object[] {
            "2020",
            "2021"});
            this.endTimeYear.Location = new System.Drawing.Point(103, 100);
            this.endTimeYear.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.endTimeYear.Name = "endTimeYear";
            this.endTimeYear.Size = new System.Drawing.Size(60, 21);
            this.endTimeYear.TabIndex = 21;
            // 
            // startTimeMonth
            // 
            this.startTimeMonth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.startTimeMonth.BackColor = System.Drawing.Color.SeaShell;
            this.startTimeMonth.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.startTimeMonth.ForeColor = System.Drawing.Color.BlueViolet;
            this.startTimeMonth.FormattingEnabled = true;
            this.startTimeMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.startTimeMonth.Location = new System.Drawing.Point(173, 72);
            this.startTimeMonth.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.startTimeMonth.Name = "startTimeMonth";
            this.startTimeMonth.Size = new System.Drawing.Size(38, 22);
            this.startTimeMonth.TabIndex = 22;
            // 
            // StartTimeDay
            // 
            this.StartTimeDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartTimeDay.BackColor = System.Drawing.Color.SeaShell;
            this.StartTimeDay.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StartTimeDay.ForeColor = System.Drawing.Color.BlueViolet;
            this.StartTimeDay.FormattingEnabled = true;
            this.StartTimeDay.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.StartTimeDay.Location = new System.Drawing.Point(220, 72);
            this.StartTimeDay.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.StartTimeDay.Name = "StartTimeDay";
            this.StartTimeDay.Size = new System.Drawing.Size(38, 22);
            this.StartTimeDay.TabIndex = 23;
            // 
            // startTimeYear
            // 
            this.startTimeYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.startTimeYear.BackColor = System.Drawing.Color.SeaShell;
            this.startTimeYear.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.startTimeYear.ForeColor = System.Drawing.Color.BlueViolet;
            this.startTimeYear.FormattingEnabled = true;
            this.startTimeYear.Items.AddRange(new object[] {
            "2020",
            "2021"});
            this.startTimeYear.Location = new System.Drawing.Point(103, 72);
            this.startTimeYear.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.startTimeYear.Name = "startTimeYear";
            this.startTimeYear.Size = new System.Drawing.Size(60, 22);
            this.startTimeYear.TabIndex = 24;
            // 
            // endTimeMonth
            // 
            this.endTimeMonth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.endTimeMonth.BackColor = System.Drawing.Color.SeaShell;
            this.endTimeMonth.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.endTimeMonth.ForeColor = System.Drawing.Color.BlueViolet;
            this.endTimeMonth.FormattingEnabled = true;
            this.endTimeMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.endTimeMonth.Location = new System.Drawing.Point(173, 100);
            this.endTimeMonth.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.endTimeMonth.Name = "endTimeMonth";
            this.endTimeMonth.Size = new System.Drawing.Size(38, 22);
            this.endTimeMonth.TabIndex = 25;
            // 
            // endTimeDay
            // 
            this.endTimeDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.endTimeDay.BackColor = System.Drawing.Color.SeaShell;
            this.endTimeDay.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.endTimeDay.ForeColor = System.Drawing.Color.BlueViolet;
            this.endTimeDay.FormattingEnabled = true;
            this.endTimeDay.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.endTimeDay.Location = new System.Drawing.Point(219, 100);
            this.endTimeDay.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.endTimeDay.Name = "endTimeDay";
            this.endTimeDay.Size = new System.Drawing.Size(38, 22);
            this.endTimeDay.TabIndex = 26;
            // 
            // progressRatio
            // 
            this.progressRatio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.progressRatio.AutoSize = true;
            this.progressRatio.BackColor = System.Drawing.Color.Transparent;
            this.progressRatio.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.progressRatio.ForeColor = System.Drawing.Color.Crimson;
            this.progressRatio.Location = new System.Drawing.Point(54, 135);
            this.progressRatio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.progressRatio.Name = "progressRatio";
            this.progressRatio.Size = new System.Drawing.Size(23, 14);
            this.progressRatio.TabIndex = 27;
            this.progressRatio.Text = "0%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.BlueViolet;
            this.label3.Location = new System.Drawing.Point(11, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "开始时间";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.BlueViolet;
            this.label4.Location = new System.Drawing.Point(13, 100);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "结束时间";
            // 
            // taskdetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressRatio);
            this.Controls.Add(this.endTimeDay);
            this.Controls.Add(this.endTimeMonth);
            this.Controls.Add(this.startTimeYear);
            this.Controls.Add(this.StartTimeDay);
            this.Controls.Add(this.startTimeMonth);
            this.Controls.Add(this.endTimeYear);
            this.Controls.Add(this.phlTrackBar1);
            this.Controls.Add(this.process);
            this.Controls.Add(this.finish);
            this.Controls.Add(this.tagBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextDetail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextSammary);
            this.Controls.Add(this.TSam);
            this.Controls.Add(this.ddlTime);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(340, 0);
            this.Name = "taskdetail";
            this.Size = new System.Drawing.Size(341, 631);
            this.Load += new System.EventHandler(this.taskdetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label ddlTime;
        public System.Windows.Forms.Label TSam;
        public System.Windows.Forms.TextBox TextSammary;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox TextDetail;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox tagBox;
        public System.Windows.Forms.Button finish;
        public System.Windows.Forms.Label process;
        public PHLTrackBar.PHLTrackBar phlTrackBar1;
        public System.Windows.Forms.ComboBox endTimeYear;
        public System.Windows.Forms.ComboBox startTimeMonth;
        public System.Windows.Forms.ComboBox StartTimeDay;
        public System.Windows.Forms.ComboBox startTimeYear;
        public System.Windows.Forms.ComboBox endTimeMonth;
        public System.Windows.Forms.ComboBox endTimeDay;
        public System.Windows.Forms.Label progressRatio;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
    }
}
