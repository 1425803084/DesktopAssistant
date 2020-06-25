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
            this.taskdetail1 = new DesktopAssistant.app.TaskDetail.taskdetail();
            this.taskLabel1 = new DesktopAssistant.app.task.TaskLabel.TaskLabel();
            this.SuspendLayout();
            // 
            // taskdetail1
            // 
            this.taskdetail1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("taskdetail1.BackgroundImage")));
            this.taskdetail1.Location = new System.Drawing.Point(365, 0);
            this.taskdetail1.Margin = new System.Windows.Forms.Padding(2);
            this.taskdetail1.MinimumSize = new System.Drawing.Size(340, 0);
            this.taskdetail1.Name = "taskdetail1";
            this.taskdetail1.Size = new System.Drawing.Size(377, 766);
            this.taskdetail1.TabIndex = 1;
            this.taskdetail1.Load += new System.EventHandler(this.taskdetail1_Load);
            // 
            // taskLabel1
            // 
            this.taskLabel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("taskLabel1.BackgroundImage")));
            this.taskLabel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.taskLabel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.taskLabel1.Location = new System.Drawing.Point(0, 0);
            this.taskLabel1.Name = "taskLabel1";
            this.taskLabel1.Size = new System.Drawing.Size(368, 766);
            this.taskLabel1.TabIndex = 2;
            this.taskLabel1.Load += new System.EventHandler(this.taskLabel1_Load_1);
            // 
            // TaskPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.taskLabel1);
            this.Controls.Add(this.taskdetail1);
            this.Name = "TaskPage";
            this.Size = new System.Drawing.Size(742, 766);
            this.Load += new System.EventHandler(this.TaskPage_Load);
            this.ResumeLayout(false);

        }


        #endregion

        private void Form2_Load(object sender, System.EventArgs e)

        {
            this.CloseDetail();
            this.Show();
        }



     
        public TaskDetail.taskdetail taskdetail1;
        public TaskLabel.TaskLabel taskLabel1;
    }
}
