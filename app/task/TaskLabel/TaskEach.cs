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

namespace DesktopAssistant.app.task.TaskLabel
{
    public partial class TaskEach : UserControl
    {

        public Task TaskIn 
        {
            get { return TaskIn; }
            set
            {
                TaskIn = value;
                this.describe.Text = value.Describe;
                this.endTime.Text = TimeUtils.Stamp2String(value.EndTime);
                this.progress.Text = string.Format("进度：{0}%", value.Progress);
                
            }
        }

        public TaskEach()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
