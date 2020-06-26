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

            taskEach.setTask(task);
            taskEach.Anchor = ((((AnchorStyles.Top | AnchorStyles.Left) | AnchorStyles.Right)));
            taskEach.BackgroundImageLayout = ImageLayout.Stretch;
            taskEach.Size = new Size(this.Size.Width , 60);
            taskEach.Location = new Point(0, 10 + (60+5) * tasks.Count);
            taskEach.TabIndex = 0;
            taskEach.Click += eventHandler;

            this.Controls.Add(taskEach);
            this.tasks.Add(taskEach);

        }

        public void Clear()
        {
            this.Controls.Clear();
            this.tasks.Clear();
        }

        public void AddTaskList(List<Task> taskList)
        {
            foreach(Task task in taskList)
            {
               
            }
        }
    }
}
