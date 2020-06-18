namespace DesktopAssistant.app.frame
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.TagSet = new System.Windows.Forms.TreeView();
            this.Tclock = new System.Windows.Forms.Button();
            this.ListS2 = new System.Windows.Forms.Button();
            this.GameM2 = new System.Windows.Forms.CheckBox();
            this.Min = new System.Windows.Forms.Label();
            this.Second = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.Pause = new System.Windows.Forms.Button();
            this.reStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TSam = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel1.BackgroundImage")));
            this.splitContainer1.Panel1.Controls.Add(this.GameM2);
            this.splitContainer1.Panel1.Controls.Add(this.TagSet);
            this.splitContainer1.Panel1.Controls.Add(this.ListS2);
            this.splitContainer1.Panel1.Controls.Add(this.Tclock);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(946, 576);
            this.splitContainer1.SplitterDistance = 255;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer2.Panel1.BackgroundImage")));
            this.splitContainer2.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.reStart);
            this.splitContainer2.Panel1.Controls.Add(this.Pause);
            this.splitContainer2.Panel1.Controls.Add(this.Start);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.Second);
            this.splitContainer2.Panel1.Controls.Add(this.Min);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer2.Panel2.BackgroundImage")));
            this.splitContainer2.Panel2.Controls.Add(this.TSam);
            this.splitContainer2.Size = new System.Drawing.Size(687, 576);
            this.splitContainer2.SplitterDistance = 364;
            this.splitContainer2.TabIndex = 0;
            // 
            // TagSet
            // 
            this.TagSet.BackColor = System.Drawing.Color.Lavender;
            this.TagSet.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TagSet.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TagSet.Location = new System.Drawing.Point(2, 174);
            this.TagSet.Name = "TagSet";
            this.TagSet.Size = new System.Drawing.Size(258, 77);
            this.TagSet.TabIndex = 5;
            // 
            // Tclock
            // 
            this.Tclock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Tclock.BackgroundImage")));
            this.Tclock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Tclock.Location = new System.Drawing.Point(-1, 87);
            this.Tclock.Name = "Tclock";
            this.Tclock.Size = new System.Drawing.Size(261, 91);
            this.Tclock.TabIndex = 4;
            this.Tclock.UseVisualStyleBackColor = true;
            // 
            // ListS2
            // 
            this.ListS2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ListS2.BackgroundImage")));
            this.ListS2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ListS2.Location = new System.Drawing.Point(-1, 0);
            this.ListS2.Name = "ListS2";
            this.ListS2.Size = new System.Drawing.Size(261, 91);
            this.ListS2.TabIndex = 3;
            this.ListS2.UseVisualStyleBackColor = true;
            // 
            // GameM2
            // 
            this.GameM2.AutoSize = true;
            this.GameM2.BackColor = System.Drawing.Color.Transparent;
            this.GameM2.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GameM2.ForeColor = System.Drawing.Color.SlateBlue;
            this.GameM2.Location = new System.Drawing.Point(120, 522);
            this.GameM2.Name = "GameM2";
            this.GameM2.Size = new System.Drawing.Size(115, 24);
            this.GameM2.TabIndex = 6;
            this.GameM2.Text = "游戏监管";
            this.GameM2.UseVisualStyleBackColor = false;
            // 
            // Min
            // 
            this.Min.AutoSize = true;
            this.Min.BackColor = System.Drawing.Color.Transparent;
            this.Min.Font = new System.Drawing.Font("黑体", 64.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Min.ForeColor = System.Drawing.Color.Snow;
            this.Min.Location = new System.Drawing.Point(7, 112);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(155, 108);
            this.Min.TabIndex = 0;
            this.Min.Text = "30";
            // 
            // Second
            // 
            this.Second.AutoSize = true;
            this.Second.BackColor = System.Drawing.Color.Transparent;
            this.Second.Font = new System.Drawing.Font("黑体", 64.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Second.ForeColor = System.Drawing.Color.Snow;
            this.Second.Location = new System.Drawing.Point(206, 112);
            this.Second.Name = "Second";
            this.Second.Size = new System.Drawing.Size(155, 108);
            this.Second.TabIndex = 1;
            this.Second.Text = "60";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("黑体", 64.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(136, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 100);
            this.label1.TabIndex = 2;
            this.label1.Text = ":";
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(194)))), ((int)(((byte)(244)))));
            this.Start.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Start.BackgroundImage")));
            this.Start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Start.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Start.ForeColor = System.Drawing.Color.BlueViolet;
            this.Start.Location = new System.Drawing.Point(22, 237);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(88, 52);
            this.Start.TabIndex = 6;
            this.Start.Text = "开始";
            this.Start.UseVisualStyleBackColor = false;
            // 
            // Pause
            // 
            this.Pause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(194)))), ((int)(((byte)(244)))));
            this.Pause.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pause.BackgroundImage")));
            this.Pause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Pause.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Pause.ForeColor = System.Drawing.Color.BlueViolet;
            this.Pause.Location = new System.Drawing.Point(138, 237);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(88, 52);
            this.Pause.TabIndex = 7;
            this.Pause.Text = "暂停";
            this.Pause.UseVisualStyleBackColor = false;
            // 
            // reStart
            // 
            this.reStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(194)))), ((int)(((byte)(244)))));
            this.reStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reStart.BackgroundImage")));
            this.reStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.reStart.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.reStart.ForeColor = System.Drawing.Color.BlueViolet;
            this.reStart.Location = new System.Drawing.Point(248, 237);
            this.reStart.Name = "reStart";
            this.reStart.Size = new System.Drawing.Size(88, 52);
            this.reStart.TabIndex = 8;
            this.reStart.Text = "复位";
            this.reStart.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.MediumPurple;
            this.label2.Location = new System.Drawing.Point(31, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "完成进度";
            // 
            // TSam
            // 
            this.TSam.AutoSize = true;
            this.TSam.BackColor = System.Drawing.Color.Transparent;
            this.TSam.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TSam.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.TSam.Location = new System.Drawing.Point(19, 20);
            this.TSam.Name = "TSam";
            this.TSam.Size = new System.Drawing.Size(116, 25);
            this.TSam.TabIndex = 12;
            this.TSam.Text = "任务列表";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 576);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TreeView TagSet;
        private System.Windows.Forms.Button ListS2;
        private System.Windows.Forms.Button Tclock;
        private System.Windows.Forms.CheckBox GameM2;
        private System.Windows.Forms.Label Min;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Second;
        private System.Windows.Forms.Button reStart;
        private System.Windows.Forms.Button Pause;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TSam;
    }
}