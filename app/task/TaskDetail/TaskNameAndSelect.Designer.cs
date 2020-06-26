namespace DesktopAssistant.app.task.TaskDetail
{
    partial class TaskNameAndSelect
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
            this.taskName = new System.Windows.Forms.TextBox();
            this.selectBox = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // taskName
            // 
            this.taskName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.taskName.BackColor = System.Drawing.Color.White;
            this.taskName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.taskName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.taskName.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.taskName.Location = new System.Drawing.Point(64, 16);
            this.taskName.Name = "taskName";
            this.taskName.Size = new System.Drawing.Size(238, 27);
            this.taskName.TabIndex = 0;
            // 
            // selectBox
            // 
            this.selectBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.selectBox.BackgroundImage = global::DesktopAssistant.Properties.Resources.selectUnSelect;
            this.selectBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.selectBox.Location = new System.Drawing.Point(16, 16);
            this.selectBox.Name = "selectBox";
            this.selectBox.Size = new System.Drawing.Size(26, 26);
            this.selectBox.TabIndex = 1;
            // 
            // TaskNameAndSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.selectBox);
            this.Controls.Add(this.taskName);
            this.Name = "TaskNameAndSelect";
            this.Size = new System.Drawing.Size(363, 58);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox taskName;
        public System.Windows.Forms.Panel selectBox;
    }
}
