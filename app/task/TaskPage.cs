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
using DesktopAssistant.app.page;
using DesktopAssistant.repository;

namespace DesktopAssistant.app.task
{
    public partial class TaskPage : UserControl
    {
        public TaskPage()
        {
            InitializeComponent();
            this.taskdetail1.Visible = false;
            this.taskdetail1.Enabled = false;
            Size = new Size(this.taskLabel1.Size.Width, Size.Height);

            taskdetail1.finish.Click += FinishClick;
            taskdetail1.update.Click += UpdateClick;

            taskLabel1.button2.Click += AddNewTask;

        }


        public void freshList()
        {
            TaskServiceImpl taskService = TaskServiceImpl.getTaskService();
            List<domain.Task> taskList = taskService.getAll();

            //this.taskLabel1.taskList1.Clear();
            
            taskList.ForEach(t => {
                this.taskLabel1.taskList1.AddTask(t, TaskClick);
            });
        }


        private void taskdetail1_Load(object sender, EventArgs e)
        {
            freshList();
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
                this.taskdetail1.task = null;
                CloseDetail();
            }

        }

        public void AddTask()
        {
            
        }

        public void ShowDetail()
        {
            this.taskdetail1.Visible = true;
            this.taskdetail1.Enabled = true;
            this.taskdetail1.fresh();
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

        private void taskLabel1_Load(object sender, EventArgs e)
        {

        }

        private void taskLabel1_Load_1(object sender, EventArgs e)
        {

        }

        public void FinishClick(object sender, EventArgs e)
        {
            this.taskdetail1.task.Finish = true;
            TaskDAO taskDAO = new TaskDAO();
            taskDAO.update(this.taskdetail1.task);

            CloseDetail();
        }

        public void UpdateClick(object sender, EventArgs e)
        {
            this.taskdetail1.SaveTask();
            TaskDAO taskDAO = new TaskDAO();
            taskDAO.update(this.taskdetail1.task);

            freshList();

            CloseDetail();
        }

        public void AddNewTask(object sender, EventArgs e)
        {
            Random random = new Random();
            domain.Task task = new domain.Task();
            task.Id = TimeUtils.DataTime2Stamp(DateTime.Now) - random.Next(1, 10000);
            task.StartTime = TimeUtils.DataTime2Stamp(DateTime.Now);
            task.EndTime = task.StartTime + 10000;
            task.TagId = 1;
            task.Progress = 10;
            task.Describe = "";
            task.Detail = "";

            TaskDAO taskDAO = new TaskDAO();
            taskDAO.insert(task);

            this.taskdetail1.task = task;
            ShowDetail();
        }


    }
}
