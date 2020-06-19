using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DesktopAssistant.domain;

namespace DesktopAssistant.app.task.TaskLabel
{
    public partial class TaskList : UserControl
    {
        public List<TaskEach> tasks = new List<TaskEach>();

        public TaskList()
        {
            InitializeComponent();
        }

        public void AddTask(Task task, EventHandler eventHandler)
        {
            TaskEach taskEach = new TaskEach();

            taskEach.TaskIn = task;
            taskEach.Anchor = this.taskEach1.Anchor = ((((AnchorStyles.Top | AnchorStyles.Left) | AnchorStyles.Right)));
            taskEach.BackColor = Color.Transparent;
            taskEach.BackgroundImageLayout = ImageLayout.Stretch;
            taskEach.Name = "taskEach1";
            taskEach.Size = new Size(this.Size.Width - 2 * 10, 70);
            taskEach.Location = new Point(10, 12 + 70 * tasks.Count);
            taskEach.TabIndex = 0;
            taskEach.Click += eventHandler;

            this.Controls.Add(taskEach);
            this.tasks.Add(taskEach);

        }

        public void AddTaskList(List<Task> taskList)
        {
            //foreach(Task task in taskList)
            //{
            //    AddTask(task);
            //}
        }
    }
}
