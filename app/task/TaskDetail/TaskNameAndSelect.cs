using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopAssistant.app.task.TaskDetail
{
    public partial class TaskNameAndSelect : UserControl
    {
        public TaskNameAndSelect()
        {
            InitializeComponent();
        }

        private void SelectBox_MouseLeave(object sender, EventArgs e)
        {
            this.selectBox.BackgroundImage = Properties.Resources.selectUnSelect;
        }

        private void SelectBox_MouseHover(object sender, EventArgs e)
        {
            this.selectBox.BackgroundImage = Properties.Resources.selectOn;
        }

    }
}
