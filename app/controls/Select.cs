using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateSet
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();


            for (int i = 1;i<= 12;i++)

                comboBox1.Items.Add(i);
            for (int i = 1; i <= 24; i++)

                comboBox2.Items.Add(i);
            int m = comboBox1.SelectedIndex;
            if(m == 1 || m == 3 || m == 5 || m == 7 || m == 8 || m == 10 || m == 12)
            {
                for (int i = 1; i <= 31; i++)

                    comboBox3.Items.Add(i);
            }
            else if(m==2)
            {
                for (int i = 1; i <= 28; i++)

                    comboBox3.Items.Add(i);
            }
            else
            {
                for (int i = 1; i <= 30; i++)

                    comboBox3.Items.Add(i);
            }
          

        }
        

    }
}
