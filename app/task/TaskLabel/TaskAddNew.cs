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
    public partial class TaskAddNew : UserControl
    {
        public TaskAddNew()
        {
            InitializeComponent();
            this.GotFocus += textBox_Focus;
            this.LostFocus += textBox_UnFocus;
            this.textBox.GotFocus += textBox_Focus;
            this.textBox.LostFocus += textBox_UnFocus;
            this.textBox.Text = "添加任务";
            this.MouseHover += mouse_Hover;
            this.MouseLeave += mouse_Leave;
        }

        public void changeTextBoxBackGround()
        {

            Color color = textBox.BackColor;
        }

        private void textBox_Focus(object sender, EventArgs e)
        {
            this.hintImage.BackgroundImage = Properties.Resources.AddSelect;
            this.BackgroundImage = Properties.Resources.addNewTaskBackgroundimageOn;
            this.textBox.BackColor = Color.FromArgb(152, 133, 166);
            this.textBox.Focus();

            if (this.textBox.Text.Equals("添加任务"))
            {
                this.textBox.Text = "";
            }
        }

        private void textBox_UnFocus(object sender, EventArgs e)
        {
            if (textBox.Text.Equals(""))
            {
                this.textBox.Text = "添加任务";
            }
            this.BackgroundImage = Properties.Resources.addNewTaskBackgroundimage;
            this.textBox.BackColor = Color.FromArgb(174, 152, 190);
            this.hintImage.BackgroundImage = Properties.Resources.Add;
        }

        public void mouse_Hover(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.addNewTaskBackgroundimageOn;
        }

        public void mouse_Leave(object sender, EventArgs e)
        {

            if (this.textBox.Focused)
            {
                return;
            }

            this.BackgroundImage = Properties.Resources.addNewTaskBackgroundimage;
        }
    }
}
