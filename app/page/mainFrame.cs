using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopAssistant.app.page
{
    public partial class mainFrame : Form
    {
        public mainFrame()
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();

            InitializeComponent();
        }

        private void taskPage1_Load(object sender, EventArgs e)
        {
            this.taskPage1.freshList();
        }
    }


}


