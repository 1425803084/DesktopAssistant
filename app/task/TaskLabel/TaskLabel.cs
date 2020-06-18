using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopAssistant.bases.utils;

namespace DesktopAssistant.app.task
{
    public partial class TaskLabel : UserControl
    {
        public TaskLabel()
        {
            InitializeComponent();
        }

        private void taskList1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void TaskLabel_Load(object sender, EventArgs e)
        {
            DateTime data = DateTime.Now;
            this.dataText.Text = TimeUtils.DataTime2String(data);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
