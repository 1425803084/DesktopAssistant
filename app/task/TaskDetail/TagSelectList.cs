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
using DesktopAssistant.repository;

namespace DesktopAssistant.app.task.TaskDetail
{
    public partial class TagSelectList : UserControl
    {

        public List<TagEach> tagEachs = new List<TagEach>();

        public TagSelectList()
        {
            InitializeComponent();
        }

        public void fresh(EventHandler e)
        {
            TagDAO tagDAO = new TagDAO();
            List<Tag> tags = tagDAO.getAll();
            foreach (Tag tag in tags)
            {
                tagEachs.Add(Add(tag, e));
            }
        }

        private TagEach Add(Tag TagIn, EventHandler e)
        {
            TagEach tagEach = new TagEach();
            tagEach.setTagIn(TagIn);
            tagEach.BackColor = Color.White;
            tagEach.Location = new Point(0, 45*tagEachs.Count);
            tagEach.Size = new Size(230, 45);
            tagEach.TabIndex = tagEachs.Count;
            tagEach.Click += e;

            this.Controls.Add(tagEach);
            return tagEach;
        }

    }
}
