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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        int[,] matrix;
        int n = 0;
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string number = textBox1.Text;
            
            try
            {
                n = Convert.ToInt32(number);
                matrix = new int[n, n];
                textBox2.Clear();
                Random random = new Random();
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        matrix[i, j] = random.Next(101);
                        textBox2.Text += matrix[i, j] + " ";
                    }
                    textBox2.Text += Environment.NewLine;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("err.Message");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            try
            {
                int reverse;
                textBox3.Clear();
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (i == j)
                        {
                            reverse = matrix[i, j];
                            matrix[i, j] = matrix[i, n - 1 - j];
                            matrix[i, n - 1 - j] = reverse;

                        }
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        textBox3.Text += matrix[i, j] + " ";
                    }
                    textBox3.Text += Environment.NewLine;

                }
            }
            catch
            {
                MessageBox.Show("Вв");
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
