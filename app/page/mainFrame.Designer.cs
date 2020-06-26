using System;
using System.Diagnostics;
using System.Windows.Forms;
using DesktopAssistant.app.task;
using DesktopAssistant.app.TaskDetail;
using DesktopAssistant.app.tomato;
using DesktopAssistant.service.exam;

namespace DesktopAssistant.app.page
{
    partial class mainFrame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainFrame));
            this.panel1 = new System.Windows.Forms.Panel();
            this.DesktopPet = new System.Windows.Forms.CheckBox();
            this.SelfStart = new System.Windows.Forms.CheckBox();
            this.GameMaster = new System.Windows.Forms.CheckBox();
            this.TClock = new System.Windows.Forms.Button();
            this.ListSet = new System.Windows.Forms.Button();
            this.taskPage1 = new DesktopAssistant.app.task.TaskPage();
            this.tomatoTimer1 = new DesktopAssistant.app.tomato.TomatoTimer();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.DesktopPet);
            this.panel1.Controls.Add(this.SelfStart);
            this.panel1.Controls.Add(this.GameMaster);
            this.panel1.Controls.Add(this.TClock);
            this.panel1.Controls.Add(this.ListSet);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 761);
            this.panel1.TabIndex = 0;
            // 
            // DesktopPet
            // 
            this.DesktopPet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DesktopPet.BackColor = System.Drawing.Color.Transparent;
            this.DesktopPet.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DesktopPet.ForeColor = System.Drawing.Color.SlateBlue;
            this.DesktopPet.Location = new System.Drawing.Point(16, 640);
            this.DesktopPet.Margin = new System.Windows.Forms.Padding(2);
            this.DesktopPet.Name = "DesktopPet";
            this.DesktopPet.Size = new System.Drawing.Size(141, 34);
            this.DesktopPet.TabIndex = 6;
            this.DesktopPet.Text = "桌面宠物";
            this.DesktopPet.UseVisualStyleBackColor = false;
            this.DesktopPet.CheckedChanged += new System.EventHandler(this.DesktopPet_CheckedChanged);
            // 
            // SelfStart
            // 
            this.SelfStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SelfStart.BackColor = System.Drawing.Color.Transparent;
            this.SelfStart.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SelfStart.ForeColor = System.Drawing.Color.SlateBlue;
            this.SelfStart.Location = new System.Drawing.Point(17, 679);
            this.SelfStart.Margin = new System.Windows.Forms.Padding(2);
            this.SelfStart.Name = "SelfStart";
            this.SelfStart.Size = new System.Drawing.Size(141, 34);
            this.SelfStart.TabIndex = 5;
            this.SelfStart.Text = "开机自启";
            this.SelfStart.UseVisualStyleBackColor = false;
            this.SelfStart.CheckedChanged += new System.EventHandler(this.SelfStart_CheckedChanged);
            // 
            // GameMaster
            // 
            this.GameMaster.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GameMaster.BackColor = System.Drawing.Color.Transparent;
            this.GameMaster.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GameMaster.ForeColor = System.Drawing.Color.SlateBlue;
            this.GameMaster.Location = new System.Drawing.Point(16, 717);
            this.GameMaster.Margin = new System.Windows.Forms.Padding(2);
            this.GameMaster.Name = "GameMaster";
            this.GameMaster.Size = new System.Drawing.Size(141, 34);
            this.GameMaster.TabIndex = 4;
            this.GameMaster.Text = "游戏监管";
            this.GameMaster.UseVisualStyleBackColor = false;
            this.GameMaster.CheckedChanged += new System.EventHandler(this.GameMaster_CheckedChanged);
            // 
            // TClock
            // 
            this.TClock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TClock.BackgroundImage")));
            this.TClock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TClock.Location = new System.Drawing.Point(2, 62);
            this.TClock.Margin = new System.Windows.Forms.Padding(2);
            this.TClock.Name = "TClock";
            this.TClock.Size = new System.Drawing.Size(186, 66);
            this.TClock.TabIndex = 3;
            this.TClock.UseVisualStyleBackColor = true;
            this.TClock.Click += new System.EventHandler(this.TClock_Click);
            // 
            // ListSet
            // 
            this.ListSet.BackColor = System.Drawing.Color.Plum;
            this.ListSet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ListSet.BackgroundImage")));
            this.ListSet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ListSet.Location = new System.Drawing.Point(2, 0);
            this.ListSet.Margin = new System.Windows.Forms.Padding(2);
            this.ListSet.Name = "ListSet";
            this.ListSet.Size = new System.Drawing.Size(186, 66);
            this.ListSet.TabIndex = 2;
            this.ListSet.UseVisualStyleBackColor = false;
            this.ListSet.Click += new System.EventHandler(this.ListSet_Click);
            // 
            // taskPage1
            // 
            this.taskPage1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taskPage1.Location = new System.Drawing.Point(189, 1);
            this.taskPage1.Name = "taskPage1";
            this.taskPage1.Size = new System.Drawing.Size(843, 761);
            this.taskPage1.TabIndex = 1;


            // 
            // tomatoTimer1
            // 
            this.tomatoTimer1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tomatoTimer1.BackgroundImage")));
            this.tomatoTimer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tomatoTimer1.Location = new System.Drawing.Point(184, -1);
            this.tomatoTimer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tomatoTimer1.Name = "tomatoTimer1";
            this.tomatoTimer1.Size = new System.Drawing.Size(373, 686);
            this.tomatoTimer1.TabIndex = 2;
            // 
            // mainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1030, 761);
            this.Controls.Add(this.taskPage1);
            this.Controls.Add(this.tomatoTimer1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "mainFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.mainFrame_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ListSet;
        private System.Windows.Forms.Button TClock;
        private System.Windows.Forms.CheckBox GameMaster;
        private System.Windows.Forms.CheckBox SelfStart;
        private Class1 class1 = new Class1();
        private examine examine = new examine();
        private System.Windows.Forms.CheckBox DesktopPet;
        public FormWindowState fwsPrevious;
        private suspensionFrame suspensionFrame;


        private void mainFrame_Load(object sender, System.EventArgs e)
        {

            // Save window state
            fwsPrevious = this.WindowState;
            suspensionFrame = new suspensionFrame(this);
            this.taskPage1.taskLabel1.button1.Click += suspensionFrame.hide;


            // Create top most window


        }

        public void RestoreWindow()

        {

            this.WindowState = fwsPrevious;

            this.ShowInTaskbar = true;

        }

        private void ListSet_Click(object sender, EventArgs e)
        {
            //this.taskPage1.Visible = true;
            //this.taskPage1.Enabled = true;
            //this.tomatoTimer1.Visible = false;
            //this.tomatoTimer1.Enabled = false;
            //this.taskPage1.freshList();
            //this.panel2.Controls.Clear();
            //this.panel2.Controls.Add(taskPage);
            //this.panel2.Show();
        }

        private void TClock_Click(object sender, EventArgs e)
        {
            //this.taskPage1.Visible = false;
            //this.taskPage1.Enabled = false;
            //this.tomatoTimer1.Visible = true;
            //this.tomatoTimer1.Enabled = true;
            //this.panel2.Controls.Clear();
            //this.panel2.Controls.Add(tomatoTimer);
            //this.panel2.Show();
        }


        private void SelfStart_CheckedChanged(object sender, EventArgs e)
        {
            this.class1.setAutoStart(this.DesktopPet.Checked);
        }

        private void GameMaster_CheckedChanged(object sender, EventArgs e)
        {
            if (this.DesktopPet.Checked == true)
            {
                this.examine.examineProcess();
            }
        }

        private void DesktopPet_CheckedChanged(object sender, EventArgs e)
        {
            if (this.DesktopPet.Checked == true)
            {
                System.Diagnostics.Process.Start(@"");
            }
            else
            {
                Process[] pProcess;
                pProcess = Process.GetProcesses();
                for (int i = 1; i <= pProcess.Length - 1; i++)
                {
                    if (pProcess[i].ProcessName == "WindowsCate")
                    {
                        pProcess[i].Kill();
                        break;
                    }
                }

            }


        }

        public TaskPage taskPage1;
        private TomatoTimer tomatoTimer1;
    }
}