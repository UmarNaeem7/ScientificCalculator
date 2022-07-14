using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ScientificCalculator
{

    public partial class calculator : Form
    {
        bool isFirst = true;

        public calculator()
        {
            InitializeComponent();
            displayScreen.KeyPress += new KeyPressEventHandler(keypressed);
            this.Text = "Scientific Calculator by Umar";
        }

        //disallow non-numeric and other unrelated keyboard keys in display screen using regex
        private void keypressed(Object o, KeyPressEventArgs e)
        {
            if (Regex.IsMatch(e.KeyChar.ToString(), @"[^0-9^+^\-^\/^\*^\(^\)^\b]"))
            { 
                e.Handled = true;
            }
        }

        private void seven_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                displayScreen.Text = "7";
                isFirst = false;
            }
            else
                displayScreen.Text += "7";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                displayScreen.Text = "8";
                isFirst = false;
            }
            else
                displayScreen.Text += "8";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                displayScreen.Text = "9";
                isFirst = false;
            }
            else
                displayScreen.Text += "9";
        }

        private void four_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                displayScreen.Text = "4";
                isFirst = false;
            }
            else
                displayScreen.Text += "4";
        }

        private void five_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                displayScreen.Text = "5";
                isFirst = false;
            }
            else
                displayScreen.Text += "5";
        }

        private void six_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                displayScreen.Text = "6";
                isFirst = false;
            }
            else
                displayScreen.Text += "6";
        }

        private void one_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                displayScreen.Text = "1";
                isFirst = false;
            }
            else
                displayScreen.Text += "1";
        }

        private void two_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                displayScreen.Text = "2";
                isFirst = false;
            }
            else
                displayScreen.Text += "2";
        }

        private void three_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                displayScreen.Text = "3";
                isFirst = false;
            }
            else
                displayScreen.Text += "3";
        }

        private void zero_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                displayScreen.Text = "0";
                isFirst = false;
            }
            else
                displayScreen.Text += "0";
        }

        private void leftBrace_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                displayScreen.Text = "(";
                isFirst = false;
            }
            else
                displayScreen.Text += "(";
        }

        private void rightBrace_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                displayScreen.Text = ")";
                isFirst = false;
            }
            else
                displayScreen.Text += ")";
        }

        private void point_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                isFirst = false;
            }
            displayScreen.Text += ".";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                isFirst = false;
            }
            displayScreen.Text += "+";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                isFirst = false;
            }
            displayScreen.Text += "-";
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                isFirst = false;
            }
            displayScreen.Text += "*";
        }

        private void divide_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                isFirst = false;
            }
            displayScreen.Text += "/";
        }

        private void clear_Click(object sender, EventArgs e)
        {

                displayScreen.Text = "0";
                isFirst = true;

        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (!isFirst)
            {
                if (displayScreen.Text.Length == 1)
                {
                    displayScreen.Text = "0";
                    isFirst = true;
                }
                else
                    displayScreen.Text = displayScreen.Text.Substring(0, displayScreen.Text.Length - 1);
   
            }
        }

        private void equal_Click(object sender, EventArgs e)
        {
            try
            {
                MSScriptControl.ScriptControl sc = new MSScriptControl.ScriptControl();
                sc.Language = "VBScript";
                string expression = displayScreen.Text;
                object result = sc.Eval(expression);
                displayScreen.Text = result.ToString();
                if (displayScreen.Text == "0")
                    isFirst = true;
            }
            catch (Exception)
            {
                displayScreen.Text = "Syntax Error";
                isFirst = true;
            }
            
        }

        private long computeFactorial(int n)
        {
            long fact = 1;
            for (int i = 1; i <= n; i++)
                fact *= i;
            return fact;
        }

        private void factorial_Click(object sender, EventArgs e)
        {
            if (!isFirst)
            {
                equal_Click(sender, e);
                if (displayScreen.Text != "Syntax Error")
                {
                    double num = double.Parse(displayScreen.Text);
                    int n = (int)num;   //truncate number
                    long fact;
                    try
                    {
                        checked
                        {
                            fact = computeFactorial(n);
                        }
                        displayScreen.Text = fact.ToString();
                    }
                    catch (OverflowException)
                    {
                        
                    }
                    
                }
            }
        }

        private void sine_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                displayScreen.Text = "sin";
                isFirst = false;
            }
            else
                displayScreen.Text += "sin";
        }

        private void cosine_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                displayScreen.Text = "cos";
                isFirst = false;
            }
            else
                displayScreen.Text += "cos";
        }

        private void tangent_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                displayScreen.Text = "tan";
                isFirst = false;
            }
            else
                displayScreen.Text += "tan";
        }

        private void exponent_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                isFirst = false;
            }
            displayScreen.Text += "^";
        }

        private void pi_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                displayScreen.Text = "3.1416";
                isFirst = false;
            }
            else
                displayScreen.Text += "3.1416";
        }

        private void squareroot_Click(object sender, EventArgs e)
        {
            if (!isFirst)
            {
                equal_Click(sender, e);
                if (displayScreen.Text != "Syntax Error")
                {
                    double num = Double.Parse(displayScreen.Text);

                        num = Math.Sqrt(num);
                        String temp =  num.ToString();
                        if (temp == "NaN")
                        {
                            displayScreen.Text = "Syntax Error";
                            isFirst = true;
                        }
                        else
                            displayScreen.Text = temp;
                }
            }
        }

        private void logarithm_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                displayScreen.Text = "log";
                isFirst = false;
            }
            else
                displayScreen.Text += "log";
        }

        private void fractionInversion_Click(object sender, EventArgs e)
        {
            if (!isFirst)
            {
                equal_Click(sender, e);
                if (displayScreen.Text != "Syntax Error")
                {
                    string s1 = "1/(";
                    string s2 = displayScreen.Text + ")";
                    displayScreen.Text = s1 + s2;
                    equal_Click(sender, e);
                }
            }
        }

        private void signInverter_Click(object sender, EventArgs e)
        {
            if (!isFirst)
            {
                equal_Click(sender, e);
                if (displayScreen.Text != "Syntax Error")
                {
                    double num = Double.Parse(displayScreen.Text);
                    num = -1 * num;
                    displayScreen.Text = num.ToString();
                }
            }
        }
    }
}
