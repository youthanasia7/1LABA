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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double[] arr = textBox1.Text.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(n => double.Parse(n.Trim())).ToArray();
                double max = arr[0];
                int index = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                               
                    max = max < arr[i] ? arr[i] : max;
                    index = max > arr[i] ? index : i;            
                    textBox2.Text = "[" + index + "]" + max.ToString();
                    
                }
            }
            catch
            {
                MessageBox.Show(
                   "Введите корректные значения",
                   "Сообщение",
                   MessageBoxButtons.OKCancel);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44 && number != 45)
            {
                e.Handled = true;
            }
        }
    }
}
