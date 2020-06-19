using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DesktopAssistant.domain;

namespace DesktopAssistant.app.TaskDetail
{
    public partial class taskdetail : UserControl
    {
        public Task task;

        public taskdetail()
        {
            InitializeComponent();
        }

        private void phlTrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            MessageBox.Show("111");
            progressRatio.Text = phlTrackBar1.T_Value.ToString();
        }

        private void TSammary_TextChanged(object sender, EventArgs e)
        {

        }

        private void process_Click(object sender, EventArgs e)
        {

        }

        private void taskdetail_Load(object sender, EventArgs e)
        {

        }

        public void SaveTask()
        {

        }
    }
}
