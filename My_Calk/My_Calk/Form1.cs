using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// Не работает фигня типа 1+1+1... Тоесть складывает только после =
// ошибка если после знака нажать еще один знак

namespace My_Calk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double num1 = 0;
        public double num2 = 0;
        string operand;
        double rez;

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0;
        }

        private void button11_Click(object sender, EventArgs e)    //+
        {
                num1 = Convert.ToInt32(textBox1.Text);
                operand = "+";
                textBox1.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)   // =
        {
            num2 = Convert.ToDouble(textBox1.Text);
            switch (operand)
            {
                case "+":
                    rez = num1 + num2;
                    break;
                case "-":
                    rez = num1 - num2;
                    break;
                case "/":
                    rez = num1 / num2;
                    break;
                case "*":
                    rez = num1 * num2;
                    break;
                default:
                    MessageBox.Show("bla bla bla");
                    break;
            }
            textBox1.Text = Convert.ToString(rez);
        }

        private void button14_Click(object sender, EventArgs e) // -
        {
            num1 = Convert.ToInt32(textBox1.Text);
            operand = "-";
            textBox1.Text = "";
          
        }

        private void button12_Click(object sender, EventArgs e)  // Del Button

        {
            textBox1.Text = "";
            num1 = 0;
            num2 = 0;

        }

        private void button15_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            operand = "*";
            textBox1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            operand = "/";
            textBox1.Text = "";
        }
    }
}
