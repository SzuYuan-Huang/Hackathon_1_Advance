using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackathon_3_Advance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == String.Empty)
            {
                MessageBox.Show("不可空白");
            }
            else
            {
                if(radioButton1.Checked)
                {
                    double F = 9.0 / 5.0 * double.Parse(textBox1.Text) + 32.0;
                    label1.Text = "結果：" + textBox1.Text + "℃ = " + F + "℉";
                }
                if(radioButton2.Checked)
                {
                    double C = (double.Parse(textBox1.Text) - 32) * 5.0 / 9.0;
                    label1.Text = "結果：" + textBox1.Text + "℉ = " + C + "℃";
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label1.Text = "結果：";
            button11.Enabled = true;
        }

        private void on_Click(object sender, EventArgs e)
        {
            if(((Button)sender).Text == ".")
            {
                if(textBox1.Text == String.Empty)
                {
                    MessageBox.Show("輸入無效");
                }
                else
                {
                    string temp = textBox1.Text;
                    temp += ((Button)sender).Text;
                    textBox1.Text = temp;
                    button11.Enabled = false;
                }
            }
            else
            {
                string temp = textBox1.Text;
                temp += ((Button)sender).Text;
                textBox1.Text = temp;
            }          
        }
    }
}
