using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopAssistant.app.TaskDetail
{
    public partial class taskdetail : UserControl
    {
        public taskdetail()
        {
            InitializeComponent();
        }

        private void phlTrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            MessageBox.Show("111");
            ProcessRatio.Text = phlTrackBar1.T_Value.ToString();
        }

    }
}
