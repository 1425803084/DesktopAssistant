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
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();

            InitializeComponent();
            CloseDetail();

            //添加新任务
            taskLabel.taskAddNew.textBox.KeyDown += TextBox_KeyDown; 
            taskLabel.taskAddNew.hintImage.Click += HintImage_Click;

            taskDetail.delete.Click += Delete_Click;
            taskDetail.back.Click += Back_Click;

            taskDetail.taskNameAndSelect.selectBox.Click += SelectBox_Click;
            taskDetail.taskNameAndSelect.selectBox.MouseHover += SelectBox_MouseHover;
            taskDetail.taskNameAndSelect.selectBox.MouseLeave += SelectBox_MouseLeave;


        }

        private void SelectBox_MouseLeave(object sender, EventArgs e)
        {
            if (!taskDetail.task.Finish)
            {
                taskDetail.taskNameAndSelect.selectBox.BackgroundImage = Properties.Resources.selectUnSelect;
            }
        }

        private void SelectBox_MouseHover(object sender, EventArgs e)
        {
            if (!taskDetail.task.Finish)
            {
                taskDetail.taskNameAndSelect.selectBox.BackgroundImage = Properties.Resources.selectOn;
            }
        }

        //返回按钮
        private void Back_Click(object sender, EventArgs e)
        {
            CloseDetail();
        }

        //删除按钮
        private void Delete_Click(object sender, EventArgs e)
        {
            this.taskDetail.task.Finish = true;
            this.taskDetail.SaveTask();
            CloseDetail();
            freshList();
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string text = taskLabel.taskAddNew.textBox.Text;
                if (!text.Equals(""))
                {
                    AddNewTask(text);
                    freshList();
                    taskLabel.taskAddNew.textBox.Text = "";
                }
            }
        }

        private void HintImage_Click(object sender, EventArgs e)
        {
            string text = taskLabel.taskAddNew.textBox.Text;
            if (!text.Equals(""))
            {
                AddNewTask(text);
                freshList();
            }
        }


        private void SelectBox_Click(object sender, EventArgs e)
        {
            //完成
            Task task = taskDetail.task;
            task.Finish = !task.Finish;
            new TaskDAO().update(task);

            if (task.Finish)
            {
                taskDetail.taskNameAndSelect.selectBox.BackgroundImage = Properties.Resources.selectSelected;
            }
            else
            {
                taskDetail.taskNameAndSelect.selectBox.BackgroundImage = Properties.Resources.selectUnSelect;
            }
            
            Font font = taskDetail.taskNameAndSelect.taskName.Font;
            taskDetail.taskNameAndSelect.taskName.Font = new Font(font.FontFamily, font.Size, font.Style ^ FontStyle.Strikeout);

        }

        public void freshList()
        {
            TaskServiceImpl taskService = TaskServiceImpl.getTaskService();
            List<Task> taskList = taskService.getAll();

            this.taskLabel.taskList1.Clear();
            
            taskList.ForEach(t => {
                this.taskLabel.taskList1.AddTask(t, TaskClick);
            });
        }

        private void TaskClick(object sender, EventArgs e)
        {
            TaskLabel.TaskEach taskEach = (TaskLabel.TaskEach)sender;

            if (this.taskDetail.task == null)
            {
                this.taskDetail.task = taskEach.TaskIn;
                ShowDetail();
            }
            else if (taskEach.TaskIn.Id != this.taskDetail.task.Id)
            {
                this.taskDetail.SaveTask();
                this.taskDetail.task = taskEach.TaskIn;
                ShowDetail();
            }
            else
            {
                this.taskDetail.SaveTask();
                this.taskDetail.task = null;
                CloseDetail();
            }

        }

        public void ShowDetail()
        {
            this.taskDetail.fresh();
            this.taskDetail.Visible = true;
            this.taskDetail.Enabled = true;
            this.taskLabel.Size = new Size(this.Size.Width - this.taskDetail.Size.Width, Size.Height);
        }

        public void CloseDetail()
        {
            this.taskDetail.Visible = false;
            this.taskDetail.Enabled = false;
            this.taskLabel.Size = Size;
        }


        public void AddNewTask(string taskName)
        {
            Random random = new Random();
            Task task = new Task();
            task.Id = TimeUtils.DataTime2Stamp(DateTime.Now);
            task.StartTime = TimeUtils.DataTime2Stamp(DateTime.Now);
            task.EndTime = task.StartTime + 60*60*24;
            task.TagId = 1;
            task.Progress = 0;
            task.Describe = taskName;
            task.Detail = " ";
            task.Finish = false;

            TaskDAO taskDAO = new TaskDAO();
            taskDAO.insert(task);
        }

        public TaskPage(mainFrame mainFrame)
        {
            InitializeComponent();
            //this.taskdetail1.Visible = false;
            //this.taskdetail1.Enabled = false;
            Size = new Size(this.taskLabel.Size.Width, Size.Height);
            taskLabel.button1.Click += hide;
            pParent = mainFrame;
        }







        private void hide(object sender, System.EventArgs e)
        {
            pParent.fwsPrevious = pParent.WindowState;

            hidenTaskPage = new TaskPage(pParent);

            CanPenetrate();
        }

        private void CanPenetrate()
        {
            uint intExTemp = GetWindowLong(this.Handle, GWL_EXSTYLE);
            uint oldGWLEx = SetWindowLong(this.Handle, GWL_EXSTYLE, WS_EX_TRANSPARENT | WS_EX_LAYERED);
            //pSon.Show();
            //this.ShowInTaskbar = false;
        }

        private void Form2_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)

        {

            if (blnMouseDown)

            {

                //Get the current position of the mouse in the screen

                ptMouseNewPos = Control.MousePosition;



                //Set window position

                ptFormNewPos.X = ptMouseNewPos.X - ptMouseCurrrnetPos.X + ptFormPos.X;

                ptFormNewPos.Y = ptMouseNewPos.Y - ptMouseCurrrnetPos.Y + ptFormPos.Y;



                //Save window position

                Location = ptFormNewPos;

                ptFormPos = ptFormNewPos;



                //Save mouse position

                ptMouseCurrrnetPos = ptMouseNewPos;

            }

        }

        private void Form2_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)

        {

            if (e.Button == MouseButtons.Left)

            {

                blnMouseDown = true;



                // Save window position and mouse position

                ptMouseCurrrnetPos = Control.MousePosition;

                ptFormPos = Location;

            }

        }

        private void Form2_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)

        {

            if (e.Button == MouseButtons.Left)

                //Return back signal

                blnMouseDown = false;

        }

        private void frmTopMost_DoubleClick(object sender, System.EventArgs e)

        {

            SwitchToMain();

        }

        private void SwitchToMain()

        {

            //Change main window status here

            pParent.RestoreWindow();

            //Hide top most window

            this.Hide();

        }

        private void mnuMainWindow_Click(object sender, System.EventArgs e)

        {

            SwitchToMain();

        }

    }
}
