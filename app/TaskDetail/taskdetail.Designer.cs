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
            this.TSammary = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TDetail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.process = new System.Windows.Forms.Label();
            this.phlTrackBar1 = new PHLTrackBar.PHLTrackBar();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.ProcessRatio = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ddlTime
            // 
            this.ddlTime.AutoSize = true;
            this.ddlTime.BackColor = System.Drawing.Color.Transparent;
            this.ddlTime.Font = new System.Drawing.Font("黑体", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ddlTime.ForeColor = System.Drawing.Color.SlateBlue;
            this.ddlTime.Location = new System.Drawing.Point(15, 24);
            this.ddlTime.Name = "ddlTime";
            this.ddlTime.Size = new System.Drawing.Size(66, 33);
            this.ddlTime.TabIndex = 6;
            this.ddlTime.Text = "DDL";
            // 
            // TSam
            // 
            this.TSam.AutoSize = true;
            this.TSam.BackColor = System.Drawing.Color.Transparent;
            this.TSam.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TSam.ForeColor = System.Drawing.Color.BlueViolet;
            this.TSam.Location = new System.Drawing.Point(10, 165);
            this.TSam.Name = "TSam";
            this.TSam.Size = new System.Drawing.Size(110, 24);
            this.TSam.TabIndex = 10;
            this.TSam.Text = "任务简介";
            // 
            // TSammary
            // 
            this.TSammary.BackColor = System.Drawing.Color.SeaShell;
            this.TSammary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TSammary.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TSammary.ForeColor = System.Drawing.Color.BlueViolet;
            this.TSammary.Location = new System.Drawing.Point(15, 200);
            this.TSammary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TSammary.Name = "TSammary";
            this.TSammary.Size = new System.Drawing.Size(284, 28);
            this.TSammary.TabIndex = 13;
            this.TSammary.Text = "任务简介";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.BlueViolet;
            this.label1.Location = new System.Drawing.Point(10, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "任务详情";
            // 
            // TDetail
            // 
            this.TDetail.BackColor = System.Drawing.Color.FloralWhite;
            this.TDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TDetail.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TDetail.ForeColor = System.Drawing.Color.DarkViolet;
            this.TDetail.Location = new System.Drawing.Point(15, 279);
            this.TDetail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TDetail.Multiline = true;
            this.TDetail.Name = "TDetail";
            this.TDetail.Size = new System.Drawing.Size(284, 198);
            this.TDetail.TabIndex = 15;
            this.TDetail.Text = "任务描述";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.MediumOrchid;
            this.label2.Location = new System.Drawing.Point(10, 498);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tag分类";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Thistle;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "学习",
            "工作",
            "实验",
            "考试"});
            this.comboBox1.Location = new System.Drawing.Point(15, 526);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 26);
            this.comboBox1.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(194)))), ((int)(((byte)(244)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.BlueViolet;
            this.button1.Location = new System.Drawing.Point(314, 526);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 62);
            this.button1.TabIndex = 18;
            this.button1.Text = "我已完成";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // process
            // 
            this.process.AutoSize = true;
            this.process.BackColor = System.Drawing.Color.Transparent;
            this.process.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.process.ForeColor = System.Drawing.Color.Crimson;
            this.process.Location = new System.Drawing.Point(300, 85);
            this.process.Name = "process";
            this.process.Size = new System.Drawing.Size(56, 21);
            this.process.TabIndex = 19;
            this.process.Text = "进度";
            // 
            // phlTrackBar1
            // 
            this.phlTrackBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(194)))), ((int)(((byte)(244)))));
            this.phlTrackBar1.ForeColor = System.Drawing.Color.Coral;
            this.phlTrackBar1.Location = new System.Drawing.Point(255, 130);
            this.phlTrackBar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.phlTrackBar1.Max = 100;
            this.phlTrackBar1.Min = 0;
            this.phlTrackBar1.Name = "phlTrackBar1";
            this.phlTrackBar1.P_Value = 50;
            this.phlTrackBar1.Progress_Color = System.Drawing.Color.LightSalmon;
            this.phlTrackBar1.ProgressBar_Color = System.Drawing.Color.Silver;
            this.phlTrackBar1.Size = new System.Drawing.Size(198, 13);
            this.phlTrackBar1.T_Value = 50;
            this.phlTrackBar1.TabIndex = 20;
            this.phlTrackBar1.TrackBar_Color = System.Drawing.Color.BlueViolet;
            this.phlTrackBar1.TrackBarVisible = true;
            this.phlTrackBar1.TrackBarWidth = 15;
            this.phlTrackBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.phlTrackBar1_Scroll);
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.SeaShell;
            this.comboBox2.Font = new System.Drawing.Font("黑体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox2.ForeColor = System.Drawing.Color.BlueViolet;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "2020",
            "2021"});
            this.comboBox2.Location = new System.Drawing.Point(17, 83);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(75, 28);
            this.comboBox2.TabIndex = 21;
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.Color.SeaShell;
            this.comboBox3.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox3.ForeColor = System.Drawing.Color.BlueViolet;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
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
            this.comboBox3.Location = new System.Drawing.Point(100, 83);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(55, 30);
            this.comboBox3.TabIndex = 22;
            // 
            // comboBox4
            // 
            this.comboBox4.BackColor = System.Drawing.Color.SeaShell;
            this.comboBox4.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox4.ForeColor = System.Drawing.Color.BlueViolet;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
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
            this.comboBox4.Location = new System.Drawing.Point(165, 83);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(55, 30);
            this.comboBox4.TabIndex = 23;
            // 
            // comboBox5
            // 
            this.comboBox5.BackColor = System.Drawing.Color.SeaShell;
            this.comboBox5.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox5.ForeColor = System.Drawing.Color.BlueViolet;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "2020",
            "2021"});
            this.comboBox5.Location = new System.Drawing.Point(17, 127);
            this.comboBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(75, 30);
            this.comboBox5.TabIndex = 24;
            // 
            // comboBox6
            // 
            this.comboBox6.BackColor = System.Drawing.Color.SeaShell;
            this.comboBox6.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox6.ForeColor = System.Drawing.Color.BlueViolet;
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
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
            this.comboBox6.Location = new System.Drawing.Point(100, 127);
            this.comboBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(55, 30);
            this.comboBox6.TabIndex = 25;
            // 
            // comboBox7
            // 
            this.comboBox7.BackColor = System.Drawing.Color.SeaShell;
            this.comboBox7.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox7.ForeColor = System.Drawing.Color.BlueViolet;
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Items.AddRange(new object[] {
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
            this.comboBox7.Location = new System.Drawing.Point(165, 127);
            this.comboBox7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(55, 30);
            this.comboBox7.TabIndex = 26;
            // 
            // ProcessRatio
            // 
            this.ProcessRatio.AutoSize = true;
            this.ProcessRatio.BackColor = System.Drawing.Color.Transparent;
            this.ProcessRatio.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ProcessRatio.ForeColor = System.Drawing.Color.Crimson;
            this.ProcessRatio.Location = new System.Drawing.Point(370, 85);
            this.ProcessRatio.Name = "ProcessRatio";
            this.ProcessRatio.Size = new System.Drawing.Size(34, 21);
            this.ProcessRatio.TabIndex = 27;
            this.ProcessRatio.Text = "0%";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(194)))), ((int)(((byte)(244)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.Color.BlueViolet;
            this.button2.Location = new System.Drawing.Point(176, 526);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 62);
            this.button2.TabIndex = 28;
            this.button2.Text = "添加";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // taskdetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ProcessRatio);
            this.Controls.Add(this.comboBox7);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.phlTrackBar1);
            this.Controls.Add(this.process);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TDetail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TSammary);
            this.Controls.Add(this.TSam);
            this.Controls.Add(this.ddlTime);
            this.Name = "taskdetail";
            this.Size = new System.Drawing.Size(463, 650);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ddlTime;
        private System.Windows.Forms.Label TSam;
        private System.Windows.Forms.TextBox TSammary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TDetail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label process;
        private PHLTrackBar.PHLTrackBar phlTrackBar1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.Label ProcessRatio;
        private System.Windows.Forms.Button button2;
    }
}
