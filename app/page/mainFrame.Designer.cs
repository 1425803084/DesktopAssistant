using System;
using System.Diagnostics;
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
            this.SelfStart = new System.Windows.Forms.CheckBox();
            this.GameMaster = new System.Windows.Forms.CheckBox();
            this.TClock = new System.Windows.Forms.Button();
            this.ListSet = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DesktopPet = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.DesktopPet);
            this.panel1.Controls.Add(this.SelfStart);
            this.panel1.Controls.Add(this.GameMaster);
            this.panel1.Controls.Add(this.TClock);
            this.panel1.Controls.Add(this.ListSet);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 576);
            this.panel1.TabIndex = 0;
            // 
            // SelfStart
            // 
            this.SelfStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SelfStart.BackColor = System.Drawing.Color.Transparent;
            this.SelfStart.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SelfStart.ForeColor = System.Drawing.Color.SlateBlue;
            this.SelfStart.Location = new System.Drawing.Point(23, 473);
            this.SelfStart.Name = "SelfStart";
            this.SelfStart.Size = new System.Drawing.Size(188, 42);
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
            this.GameMaster.Location = new System.Drawing.Point(22, 521);
            this.GameMaster.Name = "GameMaster";
            this.GameMaster.Size = new System.Drawing.Size(188, 42);
            this.GameMaster.TabIndex = 4;
            this.GameMaster.Text = "游戏监管";
            this.GameMaster.UseVisualStyleBackColor = false;
            this.GameMaster.CheckedChanged += new System.EventHandler(this.GameMaster_CheckedChanged);
            // 
            // TClock
            // 
            this.TClock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TClock.BackgroundImage")));
            this.TClock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TClock.Location = new System.Drawing.Point(3, 78);
            this.TClock.Name = "TClock";
            this.TClock.Size = new System.Drawing.Size(248, 83);
            this.TClock.TabIndex = 3;
            this.TClock.UseVisualStyleBackColor = true;
            this.TClock.Click += new System.EventHandler(this.TClock_Click);
            // 
            // ListSet
            // 
            this.ListSet.BackColor = System.Drawing.Color.Plum;
            this.ListSet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ListSet.BackgroundImage")));
            this.ListSet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ListSet.Location = new System.Drawing.Point(3, 0);
            this.ListSet.Name = "ListSet";
            this.ListSet.Size = new System.Drawing.Size(248, 83);
            this.ListSet.TabIndex = 2;
            this.ListSet.UseVisualStyleBackColor = false;
            this.ListSet.Click += new System.EventHandler(this.ListSet_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Location = new System.Drawing.Point(255, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(692, 576);
            this.panel2.TabIndex = 1;
            // 
            // DesktopPet
            // 
            this.DesktopPet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DesktopPet.BackColor = System.Drawing.Color.Transparent;
            this.DesktopPet.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DesktopPet.ForeColor = System.Drawing.Color.SlateBlue;
            this.DesktopPet.Location = new System.Drawing.Point(22, 425);
            this.DesktopPet.Name = "DesktopPet";
            this.DesktopPet.Size = new System.Drawing.Size(188, 42);
            this.DesktopPet.TabIndex = 6;
            this.DesktopPet.Text = "桌面宠物";
            this.DesktopPet.UseVisualStyleBackColor = false;
            this.DesktopPet.CheckedChanged += new System.EventHandler(this.DesktopPet_CheckedChanged);
            // 
            // mainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(946, 576);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "mainFrame";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ListSet;
        private System.Windows.Forms.Button TClock;
        private System.Windows.Forms.CheckBox GameMaster;
        private System.Windows.Forms.CheckBox SelfStart;
        private System.Windows.Forms.Panel panel2;
        private Class1 class1 = new Class1();
        private examine examine = new examine();
        private System.Windows.Forms.CheckBox DesktopPet;
        private void ListSet_Click(object sender, EventArgs e)
        {
            this.panel2.Show();
        }

        private void TClock_Click(object sender, EventArgs e)
        {
            this.panel2.Show();
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
    }
}