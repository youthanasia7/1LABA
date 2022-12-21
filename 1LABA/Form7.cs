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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EngMoney first = new EngMoney();

            try
            {
                string s1 = textBox1.Text;
                string s2 = textBox2.Text;
                string s3 = textBox3.Text;
                first.pound = double.Parse(s1);
                first.shilling = double.Parse(s2);
                first.pence = double.Parse(s3);

                first.converte = (first.pound * 240) + (first.shilling * 12) + (first.pence);

                EngMoney second = new EngMoney();

                string s4 = textBox4.Text;
                string s5 = textBox5.Text;
                string s6 = textBox6.Text;
                second.pound = double.Parse(s4);
                second.shilling = double.Parse(s5);
                second.pence = double.Parse(s6);

                second.converte = (second.pound * 240) + (second.shilling * 12) + (second.pence);

                if (radioButton1.Checked == true)
                {

                    textBox7.Text = ((first.converte + second.converte) / 240).ToString();
                    textBox8.Text = ((first.converte + second.converte) / 12).ToString();
                    textBox9.Text = ((first.converte + second.converte) / 1).ToString();
                }
                else if (radioButton2.Checked == true)
                {
                    textBox7.Text = ((first.converte - second.converte) / 240).ToString();
                    textBox8.Text = ((first.converte - second.converte) / 12).ToString();
                    textBox9.Text = ((first.converte - second.converte) / 1).ToString();
                }
                else if (radioButton3.Checked == true)
                {
                    textBox7.Text = (((first.converte - second.converte) / 240) * -1).ToString();
                    textBox8.Text = (((first.converte - second.converte) / 12) * -1).ToString();
                    textBox9.Text = (((first.converte - second.converte) / 1) * -1).ToString();
                }
                else if (radioButton4.Checked == true)
                {
                    textBox7.Text = (((first.converte * second.converte) / 240)).ToString();
                    textBox8.Text = (((first.converte * second.converte) / 12)).ToString();
                    textBox9.Text = (((first.converte * second.converte) / 1)).ToString();
                }
                else if (radioButton5.Checked == true)
                {
                    textBox7.Text = (((first.converte / second.converte) / 240)).ToString();
                    textBox8.Text = (((first.converte / second.converte) / 12)).ToString();
                    textBox9.Text = (((first.converte / second.converte) / 1)).ToString();
                }
                else if (radioButton6.Checked == true)
                {
                    textBox7.Text = (((second.converte / first.converte) / 240)).ToString();
                    textBox8.Text = (((second.converte / first.converte) / 12)).ToString();
                    textBox9.Text = (((second.converte / first.converte) / 1)).ToString();
                }
                else if (radioButton7.Checked == true)
                {
                    if (first.converte > second.converte)
                    {
                        textBox10.Text = ("Первая сумма больше чем вторая ");
                    }
                    else if (first.converte < second.converte)
                    {
                        textBox10.Text = ("Первая сумма больше чем вторая ");
                    }
                    else if (first.converte == second.converte)
                    {
                        textBox10.Text = ("Значения сумм равны");
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("err.Message");
            }

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
