namespace DesktopAssistant.app.tomato
{
    partial class TomatoTimer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TomatoTimer));
            this.label1 = new System.Windows.Forms.Label();
            this.Second = new System.Windows.Forms.Label();
            this.Min = new System.Windows.Forms.Label();
            this.reStart = new System.Windows.Forms.Button();
            this.Pause = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Hour = new System.Windows.Forms.Label();
            this.HourSelect = new System.Windows.Forms.ComboBox();
            this.MinuteSelect = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("黑体", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(316, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 92);
            this.label1.TabIndex = 5;
            this.label1.Text = ":";
            // 
            // Second
            // 
            this.Second.AutoSize = true;
            this.Second.BackColor = System.Drawing.Color.Transparent;
            this.Second.Font = new System.Drawing.Font("黑体", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Second.ForeColor = System.Drawing.Color.Snow;
            this.Second.Location = new System.Drawing.Point(369, 255);
            this.Second.Name = "Second";
            this.Second.Size = new System.Drawing.Size(104, 72);
            this.Second.TabIndex = 4;
            this.Second.Text = "00";
            // 
            // Min
            // 
            this.Min.AutoSize = true;
            this.Min.BackColor = System.Drawing.Color.Transparent;
            this.Min.Font = new System.Drawing.Font("黑体", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Min.ForeColor = System.Drawing.Color.Snow;
            this.Min.Location = new System.Drawing.Point(206, 255);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(104, 72);
            this.Min.TabIndex = 3;
            this.Min.Text = "30";
            this.toolTip1.SetToolTip(this.Min, "番茄工作法，以三十分钟为单位工作");
            // 
            // reStart
            // 
            this.reStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(194)))), ((int)(((byte)(244)))));
            this.reStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reStart.BackgroundImage")));
            this.reStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.reStart.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.reStart.ForeColor = System.Drawing.Color.BlueViolet;
            this.reStart.Location = new System.Drawing.Point(328, 372);
            this.reStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.reStart.Name = "reStart";
            this.reStart.Size = new System.Drawing.Size(123, 78);
            this.reStart.TabIndex = 11;
            this.reStart.Text = "复位";
            this.reStart.UseVisualStyleBackColor = false;
            this.reStart.Click += new System.EventHandler(this.reStart_Click);
            // 
            // Pause
            // 
            this.Pause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(194)))), ((int)(((byte)(244)))));
            this.Pause.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pause.BackgroundImage")));
            this.Pause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Pause.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Pause.ForeColor = System.Drawing.Color.BlueViolet;
            this.Pause.Location = new System.Drawing.Point(73, 372);
            this.Pause.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(123, 78);
            this.Pause.TabIndex = 10;
            this.Pause.Text = "暂停";
            this.Pause.UseVisualStyleBackColor = false;
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(194)))), ((int)(((byte)(244)))));
            this.Start.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Start.BackgroundImage")));
            this.Start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Start.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Start.ForeColor = System.Drawing.Color.BlueViolet;
            this.Start.Location = new System.Drawing.Point(199, 372);
            this.Start.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(123, 78);
            this.Start.TabIndex = 9;
            this.Start.Text = "开始";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.MediumPurple;
            this.label2.Location = new System.Drawing.Point(53, 645);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 33);
            this.label2.TabIndex = 12;
            this.label2.Text = "完成进度";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.BlueViolet;
            this.toolTip1.ForeColor = System.Drawing.Color.AliceBlue;
            this.toolTip1.IsBalloon = true;
            // 
            // Hour
            // 
            this.Hour.AutoSize = true;
            this.Hour.BackColor = System.Drawing.Color.Transparent;
            this.Hour.Font = new System.Drawing.Font("黑体", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Hour.ForeColor = System.Drawing.Color.Snow;
            this.Hour.Location = new System.Drawing.Point(61, 255);
            this.Hour.Name = "Hour";
            this.Hour.Size = new System.Drawing.Size(104, 72);
            this.Hour.TabIndex = 30;
            this.Hour.Text = "30";
            this.toolTip1.SetToolTip(this.Hour, "番茄工作法，以三十分钟为单位工作");
            // 
            // HourSelect
            // 
            this.HourSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HourSelect.BackColor = System.Drawing.Color.SeaShell;
            this.HourSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HourSelect.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HourSelect.ForeColor = System.Drawing.Color.BlueViolet;
            this.HourSelect.FormattingEnabled = true;
            this.HourSelect.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.HourSelect.Location = new System.Drawing.Point(180, 195);
            this.HourSelect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HourSelect.Name = "HourSelect";
            this.HourSelect.Size = new System.Drawing.Size(78, 30);
            this.HourSelect.TabIndex = 25;
            // 
            // MinuteSelect
            // 
            this.MinuteSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinuteSelect.BackColor = System.Drawing.Color.SeaShell;
            this.MinuteSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinuteSelect.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MinuteSelect.ForeColor = System.Drawing.Color.BlueViolet;
            this.MinuteSelect.FormattingEnabled = true;
            this.MinuteSelect.Items.AddRange(new object[] {
            "0",
            "15",
            "30",
            "45"});
            this.MinuteSelect.Location = new System.Drawing.Point(344, 193);
            this.MinuteSelect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinuteSelect.Name = "MinuteSelect";
            this.MinuteSelect.Size = new System.Drawing.Size(77, 30);
            this.MinuteSelect.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.MediumPurple;
            this.label3.Location = new System.Drawing.Point(3, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 33);
            this.label3.TabIndex = 27;
            this.label3.Text = "选择倒计时";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.MediumPurple;
            this.label4.Location = new System.Drawing.Point(306, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 26);
            this.label4.TabIndex = 28;
            this.label4.Text = "时";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.MediumPurple;
            this.label5.Location = new System.Drawing.Point(471, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 26);
            this.label5.TabIndex = 29;
            this.label5.Text = "分";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("黑体", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.Snow;
            this.label7.Location = new System.Drawing.Point(154, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 81);
            this.label7.TabIndex = 31;
            this.label7.Text = ":";
            // 
            // TomatoTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Hour);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reStart);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Second);
            this.Controls.Add(this.Min);
            this.Controls.Add(this.HourSelect);
            this.Controls.Add(this.MinuteSelect);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TomatoTimer";
            this.Size = new System.Drawing.Size(514, 842);
            this.Load += new System.EventHandler(this.TomatoTimer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Second;
        private System.Windows.Forms.Label Min;
        private System.Windows.Forms.Button reStart;
        private System.Windows.Forms.Button Pause;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.ComboBox HourSelect;
        public System.Windows.Forms.ComboBox MinuteSelect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Hour;
        private System.Windows.Forms.Label label7;
    }
}
