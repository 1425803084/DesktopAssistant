using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopAssistant.app.task.TaskLabel
{
    public partial class TaskLabel : UserControl
    {
        public TaskLabel()
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();

            InitializeComponent();

            //绑定点击事件
            this.GotFocus += self_OnFocus;

            //刷新date
            DateTime dateNow = DateTime.Now;
            string week = dateNow.DayOfWeek.ToString();
            string day = dateNow.Day.ToString();
            string month = dateNow.Month.ToString();

            this.timeText.Text = month + "月" + day + "日" + ", " + "周" + week ;
        }


        private void self_OnFocus(object sender, EventArgs e)
        {
            this.taskAddNew.Focus();
        }

 
    }
}
