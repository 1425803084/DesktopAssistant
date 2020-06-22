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

namespace DesktopAssistant.app.TaskDetail
{
    public partial class taskdetail : UserControl
    {
        public Task task;

        public taskdetail()
        {
            InitializeComponent();
        }

        private void phlTrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            MessageBox.Show("111");
            progressRatio.Text = phlTrackBar1.T_Value.ToString();
        }

        private void TSammary_TextChanged(object sender, EventArgs e)
        {

        }

        private void process_Click(object sender, EventArgs e)
        {

        }

        private void taskdetail_Load(object sender, EventArgs e)
        {

        }

        public void fresh()
        {
            if (task == null)
            {

            }
            else
            {
                //开始时间
                DateTime t1 = TimeUtils.Stamp2DateTime(task.StartTime);
                int taskyear1 = t1.Year;
                startTimeYear.Text = taskyear1.ToString();
                int taskmonth1 = t1.Month;
                startTimeMonth.Text = taskmonth1.ToString();
                int taskday1 = t1.Day;
                StartTimeDay.Text = taskday1.ToString();

                //结束时间
                DateTime t2 = TimeUtils.Stamp2DateTime(task.EndTime);
                int taskyear2 = t2.Year;
                endTimeYear.Text = taskyear2.ToString();
                int taskmonth2 = t2.Month;
                endTimeMonth.Text = taskmonth2.ToString();
                int taskday2 = t2.Day;
                endTimeDay.Text = taskday2.ToString();

                //进度
                phlTrackBar1.T_Value = task.Progress;
                progressRatio.Text = task.Progress.ToString() + "%";

                //简述
                TextSammary.Text = task.Describe;

                //详细描述
                TextDetail.Text = task.Detail;

                //tag
                tagBox.Text = task.TagId.ToString();
            }
        }

        private void finish_Click(object sender, EventArgs e)
        {
 
        }


        public void SaveTask()
        {
            //开始时间
            try
            {
                int a1 = int.Parse(startTimeYear.Text);
                int a2 = int.Parse(startTimeMonth.Text);
                int a3 = int.Parse(StartTimeDay.Text);
                DateTime t3 = new DateTime(a1, a2, a3);
                task.StartTime = TimeUtils.DataTime2Stamp(t3);
                //结束时间
                int b1 = int.Parse(endTimeYear.Text);
                int b2 = int.Parse(endTimeMonth.Text);
                int b3 = int.Parse(endTimeDay.Text);
                DateTime t4 = new DateTime(b1, b2, b3);
                task.EndTime = TimeUtils.DataTime2Stamp(t4);
            }
            catch
            {

            }
            //进度
            task.Progress = phlTrackBar1.T_Value;
            //简述
            task.Describe = TextSammary.Text;
            //详细描述
            task.Detail = TextDetail.Text;
            //tag
            task.TagId = 0;
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
