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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            listBox1.Items.Insert(listBox1.Items.Count, textBox1.Text);
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            while (true)
            {
                if (listBox1.SelectedIndices.Count == 0)
                {
                    break;
                }
                else
                {
                    foreach (int i in listBox1.SelectedIndices)
                    {
                        listBox1.Items.RemoveAt(i);
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {      
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44 )
            {
                e.Handled = true;
            }           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            double max = 0;
            string s = listBox1.Text;
            
            double[] array = new double[listBox1.Items.Count];
            for (var i = 0; i < listBox1.Items.Count; i++)
            {
               

            }
        }
    }   
}
 
