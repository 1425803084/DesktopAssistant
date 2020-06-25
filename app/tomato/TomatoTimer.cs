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
        
        //int min = 30;
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
            Hour.Text = HourSelect.Text;
            Min.Text = MinuteSelect.Text;
            Second.Text="0";

            Start.Hide();
            Pause.Show();
            reStart.Show();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Second.Text = (int.Parse(Second.Text) - 1).ToString();
            if (int.Parse(Second.Text) < 0)
            {
                Second.Text = "59";
                Min.Text = (int.Parse(Min.Text) - 1).ToString();
            }
            if (int.Parse(Min.Text) < 0)
            {
                Min.Text = "59";
                Hour.Text = (int.Parse(Hour.Text) - 1).ToString();
            }
            if (int.Parse(Hour.Text)<0)
            {
                Second.Text = "0";
                Min.Text = "0";
                Hour.Text = "0";
                timer1.Stop();
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
            Min.Text = "0";
            Second.Text = "0";
            Pause.Hide();
            reStart.Hide();
            Start.Show();
        }
    }
}
