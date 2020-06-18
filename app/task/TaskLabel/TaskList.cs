using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DesktopAssistant.domain;

namespace DesktopAssistant.app.task
{
    public partial class TaskList : UserControl
    {

        private List<TaskEach> tasks = new List<TaskEach>();

        int taskViewHeight = 70;

        int leftMargin = 10;

        int topMargin = 13;

        public TaskList()
        {
            InitializeComponent();
        }


        private void TaskList_Load(object sender, EventArgs e)
        {

        }

        private void AddTask(Task task)
        {
            TaskEach taskEach = new TaskEach();
            taskEach.Task = task;
            taskEach.Size = new Size(this.Size.Width- leftMargin*2, taskViewHeight);
            taskEach.Location = new Point(leftMargin, topMargin + tasks.Count* taskViewHeight);
            taskEach.Anchor = ((((AnchorStyles.Top | AnchorStyles.Left)| AnchorStyles.Right)));
            taskEach.BackColor = Color.Transparent;
            taskEach.BackgroundImageLayout = ImageLayout.Stretch;
            taskEach.Margin = new Padding(5);
            taskEach.Name = "task_" + tasks.Count;
            taskEach.TabIndex = 0;
            this.Controls.Add(taskEach);
            tasks.Add(taskEach);
        }

        private void AddTaskList(List<Task> tasks)
        {
            foreach(Task task in tasks)
            {
                AddTask(task);            
            }
        }

    }
}
