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

namespace DesktopAssistant.app.task
{
    public partial class TaskEach : UserControl
    {

        private Task task;

        public Task Task
        { 
            get { return task; } 
            set 
            { 
                task = value;
                this.describe.Text = task.Describe;
                this.endTime.Text = TimeUtils.Stamp2String(task.EndTime);
                this.progress.Text = string.Format("进度: {0}%", task.Progress);
            } 
        }

        public TaskEach()
        {
            InitializeComponent();
        }

        private void Task_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
