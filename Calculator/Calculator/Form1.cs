using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    
    public partial class Form1 : Form
    {

        int part1;
        int part2;
        int final_result;
        string concater;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox.Text += button2.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox.Text += button4.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox.Text += button7.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            part2 = Convert.ToInt32(textBox.Text);
            switch (concater)
            {
                case "+":
                    final_result=concater_class.sum(part1, part2);
                    textBox.Text =final_result.ToString();

                    break;
                case "-":
                    final_result = concater_class.minus(part1, part2);
                    textBox.Text = final_result.ToString();
                    break;
                case "*":
                    final_result = concater_class.multiple(part1, part2);
                    textBox.Text = final_result.ToString();
                    break;
                case "/":
                    final_result = concater_class.devide(part1, part2);
                    textBox.Text = final_result.ToString();
                    break;

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox.Text += button1.Text;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox.Text += button3.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox.Text += button6.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox.Text += button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox.Text += button9.Text;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox.Text += button0.Text;
        }

        private void buttonsum_Click(object sender, EventArgs e)
        {
                part1 = Convert.ToInt32(textBox.Text);
                textBox.Text = "";

                concater = "+";
        }

        private void buttonminus_Click(object sender, EventArgs e)
        {
            part1 = Convert.ToInt32(textBox.Text);
            textBox.Text = "";
            concater = "-";
        }

        private void buttonmultiple_Click(object sender, EventArgs e)
        {
            part1 = Convert.ToInt32(textBox.Text);
            textBox.Text = "";
            concater = "*";
        }

        private void buttondivide_Click(object sender, EventArgs e)
        {
            part1 = Convert.ToInt32(textBox.Text);
            textBox.Text = "";
            concater = "/";
        }

        private void buttonsum_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void buttonc_Click(object sender, EventArgs e)
        {
            part1 = 0;
            part2 = 0;
            final_result = 0;
            concater = "";
            textBox.Text="";

        }
    }
}
