namespace DesktopAssistant.app.frame
{
    partial class Frame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frame));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.GameMaster = new System.Windows.Forms.CheckBox();
            this.TClock = new System.Windows.Forms.Button();
            this.ListSet = new System.Windows.Forms.Button();
            this.TagSet = new System.Windows.Forms.TreeView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.Date = new System.Windows.Forms.Label();
            this.AddList = new System.Windows.Forms.Button();
            this.bottom = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ddlTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TSam = new System.Windows.Forms.Label();
            this.TSammary = new System.Windows.Forms.TextBox();
            this.TDetail = new System.Windows.Forms.TextBox();
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
            this.splitContainer1.Panel1.Controls.Add(this.GameMaster);
            this.splitContainer1.Panel1.Controls.Add(this.TClock);
            this.splitContainer1.Panel1.Controls.Add(this.ListSet);
            this.splitContainer1.Panel1.Controls.Add(this.TagSet);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(946, 576);
            this.splitContainer1.SplitterDistance = 250;
            this.splitContainer1.TabIndex = 0;
            // 
            // GameMaster
            // 
            this.GameMaster.BackColor = System.Drawing.Color.Transparent;
            this.GameMaster.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GameMaster.ForeColor = System.Drawing.Color.SlateBlue;
            this.GameMaster.Location = new System.Drawing.Point(120, 522);
            this.GameMaster.Name = "GameMaster";
            this.GameMaster.Size = new System.Drawing.Size(126, 42);
            this.GameMaster.TabIndex = 3;
            this.GameMaster.Text = "游戏监管";
            this.GameMaster.UseVisualStyleBackColor = false;
            // 
            // TClock
            // 
            this.TClock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TClock.BackgroundImage")));
            this.TClock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TClock.Location = new System.Drawing.Point(-1, 75);
            this.TClock.Name = "TClock";
            this.TClock.Size = new System.Drawing.Size(248, 83);
            this.TClock.TabIndex = 2;
            this.TClock.UseVisualStyleBackColor = true;
            // 
            // ListSet
            // 
            this.ListSet.BackColor = System.Drawing.Color.Plum;
            this.ListSet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ListSet.BackgroundImage")));
            this.ListSet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ListSet.Location = new System.Drawing.Point(0, 0);
            this.ListSet.Name = "ListSet";
            this.ListSet.Size = new System.Drawing.Size(248, 83);
            this.ListSet.TabIndex = 1;
            this.ListSet.UseVisualStyleBackColor = false;
            // 
            // TagSet
            // 
            this.TagSet.AccessibleName = "Tag";
            this.TagSet.BackColor = System.Drawing.Color.MediumPurple;
            this.TagSet.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TagSet.ForeColor = System.Drawing.Color.Snow;
            this.TagSet.LineColor = System.Drawing.Color.White;
            this.TagSet.Location = new System.Drawing.Point(1, 157);
            this.TagSet.Name = "TagSet";
            this.TagSet.Size = new System.Drawing.Size(245, 70);
            this.TagSet.TabIndex = 0;
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
            this.splitContainer2.Panel1.Controls.Add(this.Date);
            this.splitContainer2.Panel1.Controls.Add(this.AddList);
            this.splitContainer2.Panel1.Controls.Add(this.bottom);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer2.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer2.Panel2.BackgroundImage")));
            this.splitContainer2.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Panel2.Controls.Add(this.comboBox1);
            this.splitContainer2.Panel2.Controls.Add(this.button1);
            this.splitContainer2.Panel2.Controls.Add(this.ddlTime);
            this.splitContainer2.Panel2.Controls.Add(this.label1);
            this.splitContainer2.Panel2.Controls.Add(this.TSam);
            this.splitContainer2.Panel2.Controls.Add(this.TSammary);
            this.splitContainer2.Panel2.Controls.Add(this.TDetail);
            this.splitContainer2.Size = new System.Drawing.Size(692, 576);
            this.splitContainer2.SplitterDistance = 394;
            this.splitContainer2.TabIndex = 0;
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(194)))), ((int)(((byte)(244)))));
            this.Date.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Date.Font = new System.Drawing.Font("微软雅黑", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Date.ForeColor = System.Drawing.Color.Ivory;
            this.Date.Location = new System.Drawing.Point(207, 24);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(149, 59);
            this.Date.TabIndex = 2;
            this.Date.Text = "/月/日";
            this.Date.Click += new System.EventHandler(this.label1_Click);
            // 
            // AddList
            // 
            this.AddList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(194)))), ((int)(((byte)(244)))));
            this.AddList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddList.BackgroundImage")));
            this.AddList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddList.Location = new System.Drawing.Point(3, 492);
            this.AddList.Name = "AddList";
            this.AddList.Size = new System.Drawing.Size(178, 72);
            this.AddList.TabIndex = 1;
            this.AddList.UseVisualStyleBackColor = false;
            // 
            // bottom
            // 
            this.bottom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bottom.BackgroundImage")));
            this.bottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bottom.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bottom.ForeColor = System.Drawing.Color.DarkViolet;
            this.bottom.Location = new System.Drawing.Point(131, 116);
            this.bottom.Name = "bottom";
            this.bottom.Size = new System.Drawing.Size(109, 42);
            this.bottom.TabIndex = 0;
            this.bottom.Text = "置于底层";
            this.bottom.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.MediumOrchid;
            this.label2.Location = new System.Drawing.Point(33, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tag";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Thistle;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(33, 458);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(194)))), ((int)(((byte)(244)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.BlueViolet;
            this.button1.Location = new System.Drawing.Point(178, 501);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 52);
            this.button1.TabIndex = 5;
            this.button1.Text = "我已完成";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ddlTime
            // 
            this.ddlTime.AutoSize = true;
            this.ddlTime.BackColor = System.Drawing.Color.Transparent;
            this.ddlTime.Font = new System.Drawing.Font("黑体", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ddlTime.ForeColor = System.Drawing.Color.SlateBlue;
            this.ddlTime.Location = new System.Drawing.Point(18, 24);
            this.ddlTime.Name = "ddlTime";
            this.ddlTime.Size = new System.Drawing.Size(273, 38);
            this.ddlTime.TabIndex = 4;
            this.ddlTime.Text = "DDL(还有多久)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.MediumPurple;
            this.label1.Location = new System.Drawing.Point(26, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "任务详情";
            // 
            // TSam
            // 
            this.TSam.AutoSize = true;
            this.TSam.BackColor = System.Drawing.Color.Transparent;
            this.TSam.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TSam.ForeColor = System.Drawing.Color.BlueViolet;
            this.TSam.Location = new System.Drawing.Point(26, 156);
            this.TSam.Name = "TSam";
            this.TSam.Size = new System.Drawing.Size(93, 20);
            this.TSam.TabIndex = 2;
            this.TSam.Text = "任务简介";
            // 
            // TSammary
            // 
            this.TSammary.BackColor = System.Drawing.Color.SeaShell;
            this.TSammary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TSammary.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TSammary.ForeColor = System.Drawing.Color.BlueViolet;
            this.TSammary.Location = new System.Drawing.Point(26, 183);
            this.TSammary.Name = "TSammary";
            this.TSammary.Size = new System.Drawing.Size(252, 23);
            this.TSammary.TabIndex = 1;
            this.TSammary.Text = "任务简介";
            // 
            // TDetail
            // 
            this.TDetail.BackColor = System.Drawing.Color.FloralWhite;
            this.TDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TDetail.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TDetail.ForeColor = System.Drawing.Color.DarkViolet;
            this.TDetail.Location = new System.Drawing.Point(26, 254);
            this.TDetail.Multiline = true;
            this.TDetail.Name = "TDetail";
            this.TDetail.Size = new System.Drawing.Size(252, 165);
            this.TDetail.TabIndex = 0;
            this.TDetail.Text = "任务描述";
            // 
            // Frame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 576);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Frame";
            this.Text = "Frame";
            this.Load += new System.EventHandler(this.Frame_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
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
        private System.Windows.Forms.TreeView TagSet;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.CheckBox GameMaster;
        private System.Windows.Forms.Button TClock;
        private System.Windows.Forms.Button ListSet;
        private System.Windows.Forms.Button bottom;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Button AddList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ddlTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TSam;
        private System.Windows.Forms.TextBox TSammary;
        private System.Windows.Forms.TextBox TDetail;
    }
}