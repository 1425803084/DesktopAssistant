namespace DesktopAssistant.app.task.TaskDetail
{
    partial class ProgressBar
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
            this.phlTrackBar1 = new PHLTrackBar.PHLTrackBar();
            this.progressRatio = new System.Windows.Forms.Label();
            this.process = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // phlTrackBar1
            // 
            this.phlTrackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phlTrackBar1.BackColor = System.Drawing.Color.White;
            this.phlTrackBar1.ForeColor = System.Drawing.Color.Snow;
            this.phlTrackBar1.Location = new System.Drawing.Point(109, 15);
            this.phlTrackBar1.Max = 100;
            this.phlTrackBar1.Min = 0;
            this.phlTrackBar1.Name = "phlTrackBar1";
            this.phlTrackBar1.P_Value = 50;
            this.phlTrackBar1.Progress_Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(194)))), ((int)(((byte)(244)))));
            this.phlTrackBar1.ProgressBar_Color = System.Drawing.Color.Silver;
            this.phlTrackBar1.Size = new System.Drawing.Size(247, 21);
            this.phlTrackBar1.T_Value = 50;
            this.phlTrackBar1.TabIndex = 21;
            this.phlTrackBar1.TrackBar_Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(194)))), ((int)(((byte)(244)))));
            this.phlTrackBar1.TrackBarVisible = true;
            this.phlTrackBar1.TrackBarWidth = 15;
            // 
            // progressRatio
            // 
            this.progressRatio.AutoSize = true;
            this.progressRatio.BackColor = System.Drawing.Color.Transparent;
            this.progressRatio.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.progressRatio.ForeColor = System.Drawing.Color.Black;
            this.progressRatio.Location = new System.Drawing.Point(62, 15);
            this.progressRatio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.progressRatio.Name = "progressRatio";
            this.progressRatio.Size = new System.Drawing.Size(33, 21);
            this.progressRatio.TabIndex = 29;
            this.progressRatio.Text = "0%";
            // 
            // process
            // 
            this.process.AutoSize = true;
            this.process.BackColor = System.Drawing.Color.Transparent;
            this.process.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.process.ForeColor = System.Drawing.Color.Black;
            this.process.Location = new System.Drawing.Point(15, 15);
            this.process.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.process.Name = "process";
            this.process.Size = new System.Drawing.Size(58, 21);
            this.process.TabIndex = 28;
            this.process.Text = "进度：";
            this.process.Click += new System.EventHandler(this.process_Click);
            // 
            // ProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.progressRatio);
            this.Controls.Add(this.process);
            this.Controls.Add(this.phlTrackBar1);
            this.Name = "ProgressBar";
            this.Size = new System.Drawing.Size(384, 51);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public PHLTrackBar.PHLTrackBar phlTrackBar1;
        public System.Windows.Forms.Label progressRatio;
        public System.Windows.Forms.Label process;
    }
}
