using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopAssistant.domain;

namespace DesktopAssistant.app.task.TaskDetail
{
    public partial class TagEach : UserControl
    {
        public TagEach()
        {
            InitializeComponent();
            this.tagName.MouseHover += TagEach_MouseHover;
            this.image.MouseHover += TagEach_MouseHover;

        }

        public Tag TagIn;

        public void setTagIn(Tag tag)
        {
            this.TagIn = tag;
            this.tagName.Text = tag.Name;
        }

        private void TagEach_MouseHover(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.TagBackgroundOn;
        }

        private void TagEach_MouseLeave(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.TagBackground;
        }

        private void tagName_Click(object sender, EventArgs e)
        {

        }
    }
}
