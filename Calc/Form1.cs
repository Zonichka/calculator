using System.Text.RegularExpressions;

namespace Calc
{
    public partial class Form1 : Form
    {
        string pattern = @"^-?\+?[0-9]+(,?[0-9]+)?$";
        public Form1()
        {
            InitializeComponent();
        }

        private void checkValue(string a)
        {
            
        }

        private bool check(string a)
        {
            if (Regex.IsMatch(a, pattern) != true)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (check(textBox1.Text) == true)
            {
                double a;
                a = Convert.ToDouble(textBox1.Text);
                textBox3.Text = a.ToString();
                if (check(textBox2.Text) == true)
                {
                    double b;
                    b = Convert.ToDouble(textBox2.Text);

                    double c;
                    c = a + b;

                    textBox3.Text = c.ToString();
                }
                else
                {
                    textBox3.Text = "2 введенное значение не является числом";
                }
            }
            else
            {
                textBox3.Text = "1 введенное значение не является числом";
            }

        }

        private void button_subtraction_Click(object sender, EventArgs e)
        {
            if (check(textBox1.Text) == true)
            {
                double a;
                a = Convert.ToDouble(textBox1.Text);
                textBox3.Text = a.ToString();
                if (check(textBox2.Text) == true)
                {
                    double b;
                    b = Convert.ToDouble(textBox2.Text);

                    double c;
                    c = a - b;

                    textBox3.Text = c.ToString();
                }
                else
                {
                    textBox3.Text = "2 введенное значение не является числом";
                }
            }
            else
            {
                textBox3.Text = "1 введенное значение не является числом";
            }
        }

        private void button_multiply_Click(object sender, EventArgs e)
        {
            if (check(textBox1.Text) == true)
            {
                double a;
                a = Convert.ToDouble(textBox1.Text);
                textBox3.Text = a.ToString();
                if (check(textBox2.Text) == true)
                {
                    double b;
                    b = Convert.ToDouble(textBox2.Text);

                    double c;
                    c = a * b;

                    textBox3.Text = c.ToString();
                }
                else
                {
                    textBox3.Text = "2 введенное значение не является числом";
                }
            }
            else
            {
                textBox3.Text = "1 введенное значение не является числом";
            }
        }

        private void button_division_Click(object sender, EventArgs e)
        {
            if (check(textBox1.Text) == true)
            {
                double a;
                a = Convert.ToDouble(textBox1.Text);
                textBox3.Text = a.ToString();
                if (check(textBox2.Text) == true)
                {
                    double b;
                    b = Convert.ToDouble(textBox2.Text);

                    if (b != 0)
                    {
                        double c;
                        c = a / b;

                        textBox3.Text = c.ToString();
                    }
                    else
                    {
                        textBox3.Text = "Error: b=0";
                    }
                }
                else
                {
                    textBox3.Text = "not a number 2";
                }
            }
            else
            {
                textBox3.Text = "not a number 1";
            }
        }

        private void button_pow_Click(object sender, EventArgs e)
        {
            if (check(textBox1.Text) == true)
            {
                double a;
                a = Convert.ToDouble(textBox1.Text);
                textBox3.Text = a.ToString();
                if (check(textBox2.Text) == true)
                {
                    double b;
                    b = Convert.ToDouble(textBox2.Text);

                    double c;
                    c = Math.Pow(a, b);

                    textBox3.Text = c.ToString();

                }
                else
                {
                    textBox3.Text = "not a number 2";
                }
            }
            else
            {
                textBox3.Text = "not a number 1";
            }
        }

        private void button_sin_Click(object sender, EventArgs e)
        {
            if (check(textBox1.Text) == true)
            {
                double a;
                a = Convert.ToDouble(textBox1.Text);
                textBox3.Text = a.ToString();
                if (check(textBox2.Text) == true)
                {
                    double b;
                    b = Convert.ToDouble(textBox2.Text);

                    double c1, c2;
                    c1 = Math.Sin(a);
                    c2 = Math.Sin(b);
                    c1 = Math.Round(c1, 2);
                    c2 = Math.Round(c2, 2);

                    textBox3.Text = "sin(a)=" + c1.ToString() + " sin(b)="+ c2.ToString();
                }
                else
                {
                    textBox3.Text = "not a number 2";
                }
            }
            else
            {
                textBox3.Text = "not a number 1";
            }
        }

        private void button_cos_Click(object sender, EventArgs e)
        {
            {
                if (check(textBox1.Text) == true)
                {
                    double a;
                    a = Convert.ToDouble(textBox1.Text);
                    textBox3.Text = a.ToString();
                    if (check(textBox2.Text) == true)
                    {
                        double b;
                        b = Convert.ToDouble(textBox2.Text);

                        double c1, c2;
                        c1 = Math.Cos(a);
                        c2 = Math.Cos(b);
                        c1 = Math.Round(c1, 2);
                        c2 = Math.Round(c2, 2);

                        textBox3.Text = "cos(a)=" + c1.ToString() + " cos(b)=" + c2.ToString();
                    }
                    else
                    {
                        textBox3.Text = "not a number 2";
                    }
                }
                else
                {
                    textBox3.Text = "not a number 1";
                }
            }
        }

        private void button_tan_Click(object sender, EventArgs e)
        {
            {
                if (check(textBox1.Text) == true)
                {
                    double a;
                    a = Convert.ToDouble(textBox1.Text);
                    textBox3.Text = a.ToString();
                    if (check(textBox2.Text) == true)
                    {
                        double b;
                        b = Convert.ToDouble(textBox2.Text);

                        if ((a % (Math.PI / 2)) == 0 && (b % (Math.PI / 2)) == 0)
                        {
                            double c1, c2;
                            c1 = Math.Tan(a);
                            c2 = Math.Tan(b);
                            c1 = Math.Round(c1, 2);
                            c2 = Math.Round(c2, 2);

                            textBox3.Text = "tg(a)=" + c1.ToString() + " tg(b)=" + c2.ToString();
                        }
                        else
                        {
                            textBox3.Text = "number % pi/2 != 0";
                        }
                    }
                    else
                    {
                        textBox3.Text = "not a number 2";
                    }
                }
                else
                {
                    textBox3.Text = "not a number 1";
                }
            }
        }

        private void button_ctan_Click(object sender, EventArgs e)
        {
            {
                if (check(textBox1.Text) == true)
                {
                    double a;
                    a = Convert.ToDouble(textBox1.Text);
                    textBox3.Text = a.ToString();
                    if (check(textBox2.Text) == true)
                    {
                        double b;
                        b = Convert.ToDouble(textBox2.Text);

                        if ((a % (Math.PI)) == 0 && (b % (Math.PI)) == 0)
                        {
                            double c1, c2;
                            c1 = 1/Math.Tan(a);
                            c2 = 1/Math.Tan(b);
                            c1 = Math.Round(c1, 2);
                            c2 = Math.Round(c2, 2);

                            textBox3.Text = "ctg(a)=" + c1.ToString() + " ctg(b)=" + c2.ToString();
                        }
                        else
                        {
                            textBox3.Text = "number % pi/2 != 0";
                        }
                    }
                    else
                    {
                        textBox3.Text = "not a number 2";
                    }
                }
                else
                {
                    textBox3.Text = "not a number 1";
                }
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
        }
    }
}