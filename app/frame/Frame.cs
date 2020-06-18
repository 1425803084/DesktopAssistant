using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopAssistant.app.frame
{
    public partial class Frame : Form
    {


        public Frame()
        {
            InitializeComponent();
        }

        private void Frame_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            //Date显示
            Date.Text = DateTime.Now.ToString("MM月dd日");
        }
    }
}
