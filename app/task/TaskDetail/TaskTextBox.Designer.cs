namespace DesktopAssistant.app.task.TaskDetail
{
    partial class TaskTextBox
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
            this.detail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // detail
            // 
            this.detail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.detail.BackColor = System.Drawing.Color.White;
            this.detail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.detail.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.detail.ForeColor = System.Drawing.Color.Gray;
            this.detail.Location = new System.Drawing.Point(21, 14);
            this.detail.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.detail.Multiline = true;
            this.detail.Name = "detail";
            this.detail.Size = new System.Drawing.Size(289, 71);
            this.detail.TabIndex = 16;
            this.detail.Text = "添加备注";
            // 
            // TaskTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.detail);
            this.Name = "TaskTextBox";
            this.Size = new System.Drawing.Size(329, 105);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox detail;
    }
}
