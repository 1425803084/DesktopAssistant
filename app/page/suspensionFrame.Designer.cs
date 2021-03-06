﻿using DesktopAssistant.app.task;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DesktopAssistant.app.page
{
    partial class suspensionFrame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Point ptMouseCurrrnetPos, ptMouseNewPos, ptFormPos, ptFormNewPos;
        private const uint WS_EX_LAYERED = 0x80000;
        private const int WS_EX_TRANSPARENT = 0x20;
        private const int GWL_EXSTYLE = (-20);
        private bool blnMouseDown = false;
        public mainFrame pParent;
        public TaskPage hidenTaskPage;
        private ToMain pSon;
        private FormWindowState fwsPrevious;
        #region
        [DllImport("user32", EntryPoint = "GetWindowLong")]
        private static extern uint GetWindowLong(IntPtr hwnd, int nIndex);
        #endregion
        #region
        [DllImport("user32", EntryPoint = "SetWindowLong")]
        private static extern uint SetWindowLong(IntPtr hwnd, int nIndex, uint dwNewLong);
        #endregion  

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
            this.taskPage1 = new DesktopAssistant.app.task.TaskPage();
            this.SuspendLayout();
            // 
            // taskPage1
            // 
            this.taskPage1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taskPage1.Location = new System.Drawing.Point(-1, -2);
            this.taskPage1.Name = "taskPage1";
            this.taskPage1.Size = new System.Drawing.Size(407, 849);
            this.taskPage1.TabIndex = 0;
            // 
            // suspensionFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 847);
            this.Controls.Add(this.taskPage1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "suspensionFrame";
            this.Opacity = 0.7D;
            this.Text = "suspensionFrame";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public suspensionFrame(mainFrame pmain)
        {
            InitializeComponent();

            pParent = pmain;
        }

        private void Form2_Load(object sender, System.EventArgs e)
        {
            

            //this.Show();

            // Init window size and position

            this.Top = pParent.Top;

            this.Left = Screen.PrimaryScreen.Bounds.Width/2 ;
 
            fwsPrevious = this.WindowState;

            // Create top most window

            pSon = new ToMain(this);

        }

        public void hide(object sender, System.EventArgs e)
        {
            pParent.fwsPrevious = pParent.WindowState;
            this.taskPage1.freshList();
            this.Show();
            this.pParent.Visible = false;
            this.ShowInTaskbar = false;

            CanPenetrate();
        }

        private void CanPenetrate()
        {
            uint intExTemp = GetWindowLong(this.Handle, GWL_EXSTYLE);
            uint oldGWLEx = SetWindowLong(this.Handle, GWL_EXSTYLE, WS_EX_TRANSPARENT | WS_EX_LAYERED);
            pSon.Show();
            this.ShowInTaskbar = false;
        }

        private void Form2_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)

        {

            if (blnMouseDown)

            {

                //Get the current position of the mouse in the screen

                ptMouseNewPos = Control.MousePosition;



                //Set window position

                ptFormNewPos.X = ptMouseNewPos.X - ptMouseCurrrnetPos.X + ptFormPos.X;

                ptFormNewPos.Y = ptMouseNewPos.Y - ptMouseCurrrnetPos.Y + ptFormPos.Y;



                //Save window position

                Location = ptFormNewPos;

                ptFormPos = ptFormNewPos;



                //Save mouse position

                ptMouseCurrrnetPos = ptMouseNewPos;

            }

        }

        private void Form2_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)

        {

            if (e.Button == MouseButtons.Left)

            {

                blnMouseDown = true;



                // Save window position and mouse position

                ptMouseCurrrnetPos = Control.MousePosition;

                ptFormPos = Location;

            }

        }

        private void Form2_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)

        {

            if (e.Button == MouseButtons.Left)

                //Return back signal

                blnMouseDown = false;

        }

        private void frmTopMost_DoubleClick(object sender, System.EventArgs e)

        {

            SwitchToMain();

        }

        private void DoubleClick(object sender, System.EventArgs e)

        {

            SwitchToMain();

        }

        private void SwitchToMain()

        {

            //Change main window status here

            pParent.RestoreWindow();

            //Hide top most window

            this.Hide();

        }

        private void mnuMainWindow_Click(object sender, System.EventArgs e)

        {

            SwitchToMain();

        }

        public void RestoreWindow()

        {

            this.WindowState = fwsPrevious;

            this.ShowInTaskbar = true;

        }

        public TaskPage taskPage1;
    }
}