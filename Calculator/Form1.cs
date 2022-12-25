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
        public Form1()
        {
            InitializeComponent();
        }

        double num1 = 0.0;
        double num2 = 0.0;
        string operatorList = "";
        bool operatorState = false;
        private void number(object sender, EventArgs e)
        {

            Button buttonText = (Button)sender;

            if (operatorState)
            {
                this.textBox2.Text = string.Empty;
                operatorState = false;
            }
            if (this.textBox2.Text == "0")
            {
                this.textBox2.Text = string.Empty;
            }
            if (buttonText.Text == ".")
            {
                if (this.textBox2.Text.Contains("."))
                {
                    return;
                }
            }
            
            if (buttonText.Text != ".")
            {
                this.textBox2.Text = this.textBox2.Text + buttonText.Text;
                this.textBox2.Text = String.Format("{0:#,##0.#####}",double.Parse(this.textBox2.Text));
            }
            else
            {
                this.textBox2.Text = this.textBox2.Text + buttonText.Text;
            }
        



        }
        private void boxnumber(object sender, EventArgs e)
        {
            Button buttonText = (Button)sender;

            if (buttonText.Text == "C")
            {
                this.textBox2.Text = "0";
                this.textBox2.Text = "";
                num1 = 0.0;
                num2 = 0.0;
                operatorList = string.Empty;
            }

            if (buttonText.Text == "+")
            {
                num1 = double.Parse(this.textBox2.Text);
                operatorList = "+";
                operatorState = true;
                this.textBox2.Text = this.textBox2.Text + operatorList;
            }
            if (buttonText.Text == "-")
            {
                num1 = double.Parse(this.textBox2.Text);
                operatorList = "-";
                operatorState = true;
                this.textBox2.Text = this.textBox2.Text + operatorList;
            }
            {
                if (buttonText.Text == "X")
                {
                    num1 = double.Parse(this.textBox2.Text);
                    operatorList = "X";
                    operatorState = true;
                    this.textBox2.Text = this.textBox2.Text + operatorList;
                }
                if (buttonText.Text == "/")
                {
                    num1 = double.Parse(this.textBox2.Text);
                    operatorList = "/";
                    operatorState = true;
                    this.textBox2.Text = this.textBox2.Text + operatorList;
                }
                if (buttonText.Text == "=")
                {
                    num2= double.Parse(this.textBox2.Text);

                    if (operatorList == "+")
                    {
                        this.textBox2.Text = (num1 + num2).ToString();
                        this.textBox1.Text = num1.ToString() + operatorList + "=" + num2.ToString();
                    }
                    if (operatorList == "-")
                    {
                        this.textBox2.Text = (num1 - num2).ToString();
                        this.textBox1.Text = num1.ToString() + operatorList + "=" + num2.ToString();
                    }
                    if (operatorList == "X")
                    {
                        this.textBox2.Text = (num1 * num2).ToString();
                        this.textBox1.Text = num1.ToString() + operatorList + "=" + num2.ToString();
                    }
                    if (operatorList == "/")
                    {
                        this.textBox2.Text = (num1 / num2).ToString();
                        this.textBox1.Text = num1.ToString() + operatorList + "=" + num2.ToString();
                    }
                }
            }
        }
    }
}
            
                
