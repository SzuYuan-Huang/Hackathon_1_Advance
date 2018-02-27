using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackathon_4_Advance
{
    public partial class Form1 : Form
    {
        int[] number = new int[4];
        Random randomNumber;
        List<string> history;
        public Form1()
        {
            InitializeComponent();
            randomNumber = new Random();
            history = new List<string>();
            answerTextBox.Enabled = false;
            lookAnswerButton.Enabled = false;
            checkButton.Enabled = false;
            quitButton.Enabled = false;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startButton.Enabled = false;
            answerTextBox.Enabled = true;
            lookAnswerButton.Enabled = true;
            checkButton.Enabled = true;
            quitButton.Enabled = true;
            getRandom();
        }

        private void answerTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                if(answerTextBox.Text.Length < 4)
                {
                    if (((int)e.KeyChar < 48 | (int)e.KeyChar > 57))
                    {
                        e.Handled = true;
                    }
                    else
                    {
                        e.Handled = false;
                    }
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        public void getRandom()
        {
            for(int i=0;i<number.Length;i++)
            {
                number[i] = randomNumber.Next(0, 10);
                for(int j=0;j<i;j++)
                {
                    if(number[j]==number[i])
                    {
                        i--;
                        break;
                    }
                }
            }
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            if(answerTextBox.Text.Distinct().Count() < 4)
            {
                MessageBox.Show("輸入無效");
            }
            else
            {
                string answer = number[0].ToString() + number[1].ToString() + number[2].ToString() + number[3].ToString();
                int A = answer.Count((x) => answerTextBox.Text.IndexOf(x) == answer.IndexOf(x));
                int B = answer.Intersect(answerTextBox.Text).Count() - A;
                history.Add(answerTextBox.Text + " : " + A + "A" + B + "B");
                historyListBox.DataSource = null;
                historyListBox.DataSource = history;

                if(A == 4)
                {
                    MessageBox.Show("過關");
                    Application.Restart();
                }
            }
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void lookAnswerButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("答案為：" + number[0].ToString() + number[1].ToString() + number[2].ToString() + number[3].ToString());
        }
    }
}
