using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1LABA
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            string s1 = textBox2.Text;
            double z;
            if (double.TryParse(s, out double x) & double.TryParse(s1, out double y))
            {
                if (y < 0)
                {
                    z = Math.Max(Math.Pow(x, 2), Math.Pow(y, 2));
                }
                else
                {
                    z = Math.Min(x, y);
                }
                textBox3.Text = z.ToString();
            }

            else
            {
                MessageBox.Show(
                    "Введите корректные значения",
                    "Сообщение",
                    MessageBoxButtons.OKCancel);
            }
                
           
            
           
          
        }
    }
}
