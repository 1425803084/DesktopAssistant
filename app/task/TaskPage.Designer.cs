using DesktopAssistant.app.page;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DesktopAssistant.app.task
{
    partial class TaskPage
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Point ptMouseCurrrnetPos, ptMouseNewPos, ptFormPos, ptFormNewPos;
        private const uint WS_EX_LAYERED = 0x80000;
        private const int WS_EX_TRANSPARENT = 0x20;
        private const int GWL_EXSTYLE = (-20);
        private bool blnMouseDown = false;
        private mainFrame pParent;
        private TaskPage hidenTaskPage;
        #region
        [DllImport("user32", EntryPoint = "GetWindowLong")]
        private static extern uint GetWindowLong(IntPtr hwnd, int nIndex);
        #endregion
        #region
        [DllImport("user32", EntryPoint = "SetWindowLong")]
        private static extern uint SetWindowLong(IntPtr hwnd, int nIndex, uint dwNewLong);
        #endregion  

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskPage));
            this.taskDetail = new DesktopAssistant.app.TaskDetail.Taskdetail();
            this.taskLabel = new DesktopAssistant.app.task.TaskLabel.TaskLabel();
            this.SuspendLayout();
            // 
            // taskDetail
            // 
            this.taskDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taskDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.taskDetail.Location = new System.Drawing.Point(564, 0);
            this.taskDetail.Margin = new System.Windows.Forms.Padding(2);
            this.taskDetail.MinimumSize = new System.Drawing.Size(340, 0);
            this.taskDetail.Name = "taskDetail";
            this.taskDetail.Size = new System.Drawing.Size(366, 770);
            this.taskDetail.TabIndex = 1;
            // 
            // taskLabel
            // 
            this.taskLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taskLabel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("taskLabel.BackgroundImage")));
            this.taskLabel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.taskLabel.Location = new System.Drawing.Point(0, 0);
            this.taskLabel.Name = "taskLabel";
            this.taskLabel.Size = new System.Drawing.Size(563, 772);
            this.taskLabel.TabIndex = 0;
            // 
            // TaskPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.taskDetail);
            this.Controls.Add(this.taskLabel);
            this.Name = "TaskPage";
            this.Size = new System.Drawing.Size(930, 772);
            this.DoubleClick += new System.EventHandler(this.frmTopMost_DoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseUp);
            this.ResumeLayout(false);

        }


        #endregion

        private TaskLabel.TaskLabel taskLabel;
        private app.TaskDetail.Taskdetail taskDetail;
    }
}
