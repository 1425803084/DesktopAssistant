namespace DesktopAssistant.app.controls
{
    partial class TrackBar
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
            this.process = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // phlTrackBar1
            // 
            this.phlTrackBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(194)))), ((int)(((byte)(244)))));
            this.phlTrackBar1.Location = new System.Drawing.Point(15, 44);
            this.phlTrackBar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.phlTrackBar1.Max = 100;
            this.phlTrackBar1.Min = 0;
            this.phlTrackBar1.Name = "phlTrackBar1";
            this.phlTrackBar1.P_Value = 50;
            this.phlTrackBar1.Progress_Color = System.Drawing.Color.LightSalmon;
            this.phlTrackBar1.ProgressBar_Color = System.Drawing.Color.Silver;
            this.phlTrackBar1.Size = new System.Drawing.Size(253, 23);
            this.phlTrackBar1.T_Value = 50;
            this.phlTrackBar1.TabIndex = 0;
            this.phlTrackBar1.TrackBar_Color = System.Drawing.Color.BlueViolet;
            this.phlTrackBar1.TrackBarVisible = true;
            this.phlTrackBar1.TrackBarWidth = 15;
            // 
            // process
            // 
            this.process.AutoSize = true;
            this.process.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.process.ForeColor = System.Drawing.Color.Crimson;
            this.process.Location = new System.Drawing.Point(94, 11);
            this.process.Name = "process";
            this.process.Size = new System.Drawing.Size(85, 28);
            this.process.TabIndex = 1;
            this.process.Text = "进度%";
            // 
            // TrackBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(194)))), ((int)(((byte)(244)))));
            this.Controls.Add(this.process);
            this.Controls.Add(this.phlTrackBar1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TrackBar";
            this.Size = new System.Drawing.Size(285, 92);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PHLTrackBar.PHLTrackBar phlTrackBar1;
        private System.Windows.Forms.Label process;
    }
}
