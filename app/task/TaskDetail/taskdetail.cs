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
using DesktopAssistant.repository;
using DesktopAssistant.app.task.TaskDetail;
using DesktopAssistant.bases.constants;

namespace DesktopAssistant.app.TaskDetail
{
    public partial class Taskdetail : UserControl
    {
        public Task task;

        public Taskdetail()
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();

            InitializeComponent();

            this.taskTextBox1.detail.LostFocus += Detail_LostFocus;
            this.taskTextBox1.detail.GotFocus += Detail_GotFocus;
            this.tagLabel.Click += TagLabel_Click;

            this.progressBar.phlTrackBar1.TrackBar += PhlTrackBar1_TrackBar;
            this.progressBar.phlTrackBar1.LostFocus += PhlTrackBar1_LostFocus;

            this.timePanel.MouseHover += TimePanel_MouseHover;
            this.timePanel.MouseLeave += TimePanel_MouseLeave;
            this.tagPanel.MouseHover += TagPanel_MouseHover;
            this.tagPanel.MouseLeave += TagPanel_MouseLeave;

            this.timeImage.MouseHover += TimePanel_MouseHover;
            this.timeLabel.MouseHover += TimePanel_MouseHover;
            this.tagImage.MouseHover += TagPanel_MouseHover;
            this.tagLabel.MouseHover += TagPanel_MouseHover;

        }

        private void TagPanel_MouseLeave(object sender, EventArgs e)
        {
            if (!this.RectangleToScreen(this.tagPanel.ClientRectangle).Contains(MousePosition))
            {
                this.tagPanel.BackColor = GroundColors.TaskBackGround;
            }
        }

        private void TimePanel_MouseLeave(object sender, EventArgs e)
        {
            if (!this.RectangleToScreen(this.timePanel.ClientRectangle).Contains(MousePosition))
            {
                this.timePanel.BackColor = GroundColors.TaskBackGround;
            }
        }

        private void TagPanel_MouseHover(object sender, EventArgs e)
        {
            this.tagPanel.BackColor = GroundColors.TaskBackGroundOn;
        }

        private void TimePanel_MouseHover(object sender, EventArgs e)
        {
            this.timePanel.BackColor = GroundColors.TaskBackGroundOn;
        }

        private void PhlTrackBar1_LostFocus(object sender, EventArgs e)
        {
            this.task.Progress = this.progressBar.phlTrackBar1.P_Value;
            SaveTask();
        }

        private void PhlTrackBar1_TrackBar()
        {
            int value = this.progressBar.phlTrackBar1.T_Value;
            this.progressBar.phlTrackBar1.P_Value = value;

            this.progressBar.progressRatio.Text = value + "%";
        }

        private void TagSelectList_LostFocus(object sender, EventArgs e)
        {
            this.tagSelectList.Visible = false;
            this.tagSelectList.Enabled = false;
        }

        private void TagLabel_Click(object sender, EventArgs e)
        {
            tagSelectList.fresh(tagClick);
            this.tagSelectList.Visible = true;
            this.tagSelectList.Enabled = true;
            this.tagSelectList.Focus();
            this.tagSelectList.LostFocus += TagSelectList_LostFocus;
        }

        public void tagClick(object sender, EventArgs e)
        {
            TagEach tagEach = (TagEach)sender;
            
            Tag tag = tagEach.TagIn;
            setTag(tag.Id);

            this.tagSelectList.Visible = false;
            this.tagSelectList.Enabled = false;

            this.tagSelectList.LostFocus -= TagSelectList_LostFocus;
        }

        //备注聚焦
        private void Detail_GotFocus(object sender, EventArgs e)
        {
            if (this.taskTextBox1.detail.Text.Equals("添加备注"))
            {
                this.taskTextBox1.detail.Text = "";
            }
        }

        //备注失去焦点
        private void Detail_LostFocus(object sender, EventArgs e)
        {
            
            if (!this.taskTextBox1.detail.Text.Equals("") && !this.taskTextBox1.detail.Text.Equals("添加备注"))
            {
                this.task.Detail = this.taskTextBox1.detail.Text;
            }
            else
            {
                this.task.Detail = "";
            }

            SaveTask();

            if (this.taskTextBox1.detail.Text.Equals(""))
            {
                this.taskTextBox1.detail.Text = "添加备注";
            }
        }

        private void phlTrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            MessageBox.Show("111");
        }

        //刷新整个
        public void fresh()
        {
            if(task != null)
            {
                setNameAndSelect(task.Describe, task.Finish);
                setTime(TimeUtils.Stamp2DateTime(task.EndTime));
                setTag(task.TagId);
                setDetail(task.Detail);
                setProgress(task.Progress);
            }
        }

        public void setNameAndSelect(string describe, bool finish)
        {
            this.taskNameAndSelect.taskName.Text = task.Describe;

            if (task.Finish)
            {
                this.taskNameAndSelect.selectBox.BackgroundImage = Properties.Resources.selectSelected;
                Font font = this.taskNameAndSelect.taskName.Font;
                this.taskNameAndSelect.taskName.Font = new Font(font.FontFamily, font.Size, font.Style ^ FontStyle.Strikeout);
            }
        }

        public void setTime(DateTime dateTime)
        {
            if (TimeUtils.DataTime2Stamp(dateTime) != 1)
            {
                string day = dateTime.Day.ToString();
                string month = dateTime.Month.ToString();
                string week = dateTime.DayOfWeek.ToString();

                this.timeLabel.Text = String.Format("{0}月{1}日, 周{2} 到期", month, day, week);

                if (dateTime < DateTime.Now)
                {
                    this.timeLabel.ForeColor = Color.FromArgb(227, 87, 89);
                }
                else
                {
                    this.timeLabel.ForeColor = Color.FromArgb(55, 97, 241);
                }

                this.timeDelete.Enabled = true;
                this.timeDelete.Visible = true;
            }
            else
            {
                this.timeDelete.Enabled = false;
                this.timeDelete.Visible = false;
                this.timeLabel.ForeColor = SystemColors.GrayText;
                this.timeLabel.Text = "添加截止时间";
            }
            
        }

        public void setTag(int tagId)
        {
            if (tagId != 999)
            {
                Tag tag = new TagDAO().getById(tagId);

                this.tagLabel.Text = tag.Name;
                this.tagLabel.ForeColor = Color.FromArgb(55, 97, 241);

                this.timeDelete.Enabled = true;
                this.timeDelete.Visible = true;
            }
            else
            {
                this.timeLabel.ForeColor = SystemColors.GrayText;
                this.timeLabel.Text = "添加任务标记";
            }
            
        }

        public void setDetail(string detail)
        {
            if (detail != null && !detail.Equals(""))
            {
                this.taskTextBox1.detail.Text = detail;
                this.taskTextBox1.detail.ForeColor = Color.Black;
            }
            else
            {
                this.taskTextBox1.detail.Text = "添加备注";
                this.taskTextBox1.ForeColor = SystemColors.GrayText;
            }
        }

        public void setProgress(int progress)
        {
            this.progressBar.phlTrackBar1.T_Value = progress;
            this.progressBar.phlTrackBar1.P_Value = progress;

            this.progressBar.progressRatio.Text = progress + "%";
        }

        public void SaveTask()
        {
            new TaskDAO().update(task);
        }
       
        //
        private void timeLabel_Click(object sender, EventArgs e)
        {
            this.monthCalendar1.Visible = true;
            this.monthCalendar1.Enabled = true;
        }

        private void tagDelete_Click(object sender, EventArgs e)
        {
            this.timeLabel.ForeColor = SystemColors.GrayText;
            this.timeLabel.Text = "添加任务标记";
            this.tagDelete.Enabled = false;
            this.tagDelete.Visible = false;

            this.task.TagId = 999;
            SaveTask();
        }

        private void timeDelete_Click(object sender, EventArgs e)
        {
            this.timeLabel.ForeColor = SystemColors.GrayText;
            this.timeLabel.Text = "添加截止时间";
            this.timeDelete.Enabled = false;
            this.timeDelete.Visible = false;

            this.task.EndTime = 1;
            SaveTask();
        }


        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime start = e.Start;
            DateTime end = e.End;
            this.task.StartTime = TimeUtils.DataTime2Stamp(start);
            this.task.EndTime = TimeUtils.DataTime2Stamp(end);

            setTime(end);

            this.monthCalendar1.Visible = false;
            this.monthCalendar1.Enabled = false;

            SaveTask();
        }
    }
}
