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
            InitializeComponent();
        }

        private void TaskLabel_Load(object sender, EventArgs e)
        {
            this.timeText.Text = DateTime.Now.ToString("MM月dd日HH时");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ;
        }
    }
}
