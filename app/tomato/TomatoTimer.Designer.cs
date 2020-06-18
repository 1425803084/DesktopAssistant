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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("黑体", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(180, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 112);
            this.label1.TabIndex = 5;
            this.label1.Text = ":";
            // 
            // Second
            // 
            this.Second.AutoSize = true;
            this.Second.BackColor = System.Drawing.Color.Transparent;
            this.Second.Font = new System.Drawing.Font("黑体", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Second.ForeColor = System.Drawing.Color.Snow;
            this.Second.Location = new System.Drawing.Point(267, 149);
            this.Second.Name = "Second";
            this.Second.Size = new System.Drawing.Size(172, 120);
            this.Second.TabIndex = 4;
            this.Second.Text = "00";
            // 
            // Min
            // 
            this.Min.AutoSize = true;
            this.Min.BackColor = System.Drawing.Color.Transparent;
            this.Min.Font = new System.Drawing.Font("黑体", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Min.ForeColor = System.Drawing.Color.Snow;
            this.Min.Location = new System.Drawing.Point(31, 149);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(172, 120);
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
            this.reStart.Location = new System.Drawing.Point(292, 310);
            this.reStart.Name = "reStart";
            this.reStart.Size = new System.Drawing.Size(109, 65);
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
            this.Pause.Location = new System.Drawing.Point(65, 310);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(109, 65);
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
            this.Start.Location = new System.Drawing.Point(177, 310);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(109, 65);
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
            this.label2.Location = new System.Drawing.Point(46, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 28);
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
            // TomatoTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reStart);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Second);
            this.Controls.Add(this.Min);
            this.DoubleBuffered = true;
            this.Name = "TomatoTimer";
            this.Size = new System.Drawing.Size(457, 702);
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
    }
}
