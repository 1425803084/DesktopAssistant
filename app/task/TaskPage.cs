using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DesktopAssistant.service.task.impl;
using DesktopAssistant.domain;
using DesktopAssistant.bases.utils;

namespace DesktopAssistant.app.task
{
    public partial class TaskPage : UserControl
    {

        TaskServiceImpl taskService = TaskServiceImpl.getTaskService();

        public TaskPage()
        {
            InitializeComponent();
            this.taskdetail1.Visible = false;
            this.taskdetail1.Enabled = false;
            Size = new Size(this.taskLabel1.Size.Width, Size.Height);
               
        }

        private void taskdetail1_Load(object sender, EventArgs e)
        {
            List<Task> taskList =  taskService.getAll();

            taskList.ForEach(t => {
                this.taskLabel1.taskList1.AddTask(t, TaskClick);
            });
        }


        private void TaskClick(object sender, EventArgs e)
        {
            TaskLabel.TaskEach taskEach = (TaskLabel.TaskEach)sender;

            if (this.taskdetail1.task == null)
            {
                this.taskdetail1.task = taskEach.TaskIn;
                ShowDetail();
            }
            else if ( taskEach.TaskIn.Id != this.taskdetail1.task.Id)
            {
                this.taskdetail1.SaveTask();
                this.taskdetail1.task = taskEach.TaskIn;
                ShowDetail();
            }
            else
            {
                this.taskdetail1.SaveTask();
                CloseDetail();
            }

        }

        public void AddTask()
        {
            Random random = new Random();
            Task task = new Task();
            task.Id = TimeUtils.DataTime2Stamp(DateTime.Now) - random.Next(1, 10000);
            task.StartTime = TimeUtils.DataTime2Stamp(DateTime.Now);
            task.EndTime = task.StartTime + 10000;

        }

        public void ShowDetail()
        {
            this.taskdetail1.Visible = true;
            this.taskdetail1.Enabled = true;
            Size = new Size(this.taskLabel1.Size.Width+this.taskdetail1.Size.Width, Size.Height);
        }

        public void CloseDetail()
        {
            this.taskdetail1.Visible = false;
            this.taskdetail1.Enabled = false;
            Size = new Size(this.taskLabel1.Size.Width, Size.Height);
        }

        private void TaskPage_Load(object sender, EventArgs e)
        {

        }
    }
}
