using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopAssistant.app.tomato
{
    public partial class TomatoTimer : UserControl
    {
        int min = 30;
        int sec = 0;
        int flag = 0;
        public TomatoTimer()
        {
            InitializeComponent();
        }

        private void TomatoTimer_Load(object sender, EventArgs e)
        {

           
            Pause.Hide();
            reStart.Hide();

        }

        private void Start_Click(object sender, EventArgs e)
        {
            min = 30;
            sec = 0;

            Start.Hide();
            Pause.Show();
            reStart.Show();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sec--;
            if (sec < 0)
            {
                sec = 59;
                min--;
            }
            if (min < 0)
            {
                timer1.Stop();
                Min.Text = "00";
                Second.Text = "00";
            }
            else
            {
                Second.Text = sec.ToString("D2");
                Min.Text = min.ToString("D2");
            }
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                timer1.Stop();
                flag = 1;
                Pause.Text = "开始";
            }
            else
            {
                timer1.Start();
                flag = 0;
                Pause.Text = "暂停";
            }
        }

        private void reStart_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Min.Text = "00";
            Second.Text = "00";
            Pause.Hide();
            reStart.Hide();
            Start.Show();
            min = 0;
            sec = 0;
        }
    }
}
