using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DesktopAssistant.domain;
using DesktopAssistant.bases.utils;
using System.Drawing.Drawing2D;
using DesktopAssistant.bases.constants;
using DesktopAssistant.repository;

namespace DesktopAssistant.app.task.TaskLabel
{
    public partial class TaskEach : UserControl
    {

        public Task TaskIn;

        public TaskEach()
        {
            InitializeComponent();

            //背景颜色
            this.BackColor = GroundColors.TaskBackGround;

            //设置圆角
            SetWindowRegion(10);
        }

        public void setTask(Task task)
        {
            TaskIn = task;
            this.describe.Text = task.Describe;
            this.endTime.Text = TimeUtils.Stamp2String(task.EndTime);
            this.progress.Text = string.Format("进度：{0}%", task.Progress);

            this.MouseHover += mouse_Hover;
            this.MouseLeave += mouse_Leave;

            this.select.MouseHover += mouse_Hover;
            this.describe.MouseHover += mouse_Hover;
            this.progress.MouseHover += mouse_Hover;
            this.endTime.MouseHover += mouse_Hover;

            this.select.MouseHover += Select_MouseHover;
            this.select.MouseLeave += Select_MouseLeave;

            this.select.Click += Select_Click;
        }

        private void Select_Click(object sender, EventArgs e)
        {
            Font font = this.describe.Font;

            this.describe.Font = new Font(font.FontFamily, font.Size, font.Style ^ FontStyle.Strikeout);
            this.TaskIn.Finish = !this.TaskIn.Finish;

            if (this.TaskIn.Finish)
            {
                this.select.BackgroundImage = Properties.Resources.selectSelected;
            }
            else
            {
                this.select.BackgroundImage = Properties.Resources.selectUnSelect;
            }

            new TaskDAO().update(this.TaskIn);
        }

        private void Select_MouseLeave(object sender, EventArgs e)
        {
            if (!TaskIn.Finish)
            {
                this.select.BackgroundImage = Properties.Resources.selectUnSelect;
            }
        }

        private void Select_MouseHover(object sender, EventArgs e)
        {
            if (!TaskIn.Finish)
            {
                this.select.BackgroundImage = Properties.Resources.selectOn;
            }
        }
        
        public void mouse_Hover(object sender, EventArgs e)
        {
            this.BackColor = GroundColors.TaskBackGroundOn;
        }

        public void mouse_Leave(object sender, EventArgs e)
        {
            if (!this.RectangleToScreen(this.ClientRectangle).Contains(MousePosition))
            {
                this.BackColor = GroundColors.TaskBackGround;
            }
        }



        public void SetWindowRegion(int radius)
        {
            GraphicsPath FormPath= new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            FormPath = GetRoundedRectPath(rect, radius);
            this.Region = new Region(FormPath);
        }

        private GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
        {
            int diameter = radius;
            Rectangle arcRect = new Rectangle(rect.Location, new Size(diameter, diameter));
            GraphicsPath path = new GraphicsPath();

            // 左上角
            path.AddArc(arcRect, 180, 90);

            // 右上角
            arcRect.X = rect.Right - diameter;
            path.AddArc(arcRect, 270, 90);

            // 右下角
            arcRect.Y = rect.Bottom - diameter;
            path.AddArc(arcRect, 0, 90);

            // 左下角
            arcRect.X = rect.Left;
            path.AddArc(arcRect, 90, 90);
            path.CloseFigure();//闭合曲线
            return path;
        }

        private void TaskEach_SizeChanged(object sender, EventArgs e)
        {
            SetWindowRegion(10);
        }
    }
}
