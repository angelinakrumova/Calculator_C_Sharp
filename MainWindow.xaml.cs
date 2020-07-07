using System;
using System.Windows;
using System.Windows.Controls;

namespace Calculator
{
    /// <summary>
    /// floateraction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private float a;
        private float num;
        private Operations op;
        private Button btn;

        private enum Operations
        {
            ADDITION,
            SUBTRACTION,
            MULTIPLICATION,
            DIVISION
        }

        public MainWindow()
        {
            InitializeComponent();
        }
        
        //updates the equation textboxes 
        private void addNum(float n)
        {
            calculations_Txt.Text += n;
            equation_Txt.Text += n;
        }

        //special buttons
        private void btn_C(object sender, RoutedEventArgs e)
        {
            calculations_Txt.Text = "";
            equation_Txt.Text = "";
            a = 0;
        }
        private void btn_dot(object sender, RoutedEventArgs e)
        {
            calculations_Txt.Text += ".";
            equation_Txt.Text += ".";
        }

        // Operations
        private void arithmeticOperations(object sender, RoutedEventArgs e)
        {
            a = float.Parse(calculations_Txt.Text);
            calculations_Txt.Text = "";

            if (sender is Button)
            {
                btn = (Button)sender;

                if (btn.Name.Equals("addition")){
                    op = Operations.ADDITION;
                    equation_Txt.Text += " + ";
                }
                if (btn.Name.Equals("sutbraction"))
                {
                    op = Operations.SUBTRACTION;
                    equation_Txt.Text += " - ";
                }
                if (btn.Name.Equals("multiplication"))
                {
                    op = Operations.MULTIPLICATION;
                    equation_Txt.Text += " * ";
                }
                if (btn.Name.Equals("division"))
                {
                    op = Operations.DIVISION;
                    equation_Txt.Text += " / ";
                }
            }
        }

        //enter numbers
        private void EnterNumbers(object sender, RoutedEventArgs e)
        {
            if (sender is Button)
            {
                btn = (Button)sender;
                for (int i = 0; i < 10; i++)
                {
                    if (btn.Name.Contains(i.ToString()))
                    {
                        num = i;
                        addNum(i);
                    }
                }
            }
        }
        
        //calculate and print result
        private void btn_equal(object sender, RoutedEventArgs e)
        {
            float result;
            float b;
            int i = (int)op;
            b = float.Parse(calculations_Txt.Text);
            equation_Txt.Text += " = ";
            switch (i)
            {
                case 0: //sum
                    result = (a + b);
                    calculations_Txt.Text = Convert.ToString(result);
                    a = b;
                    equation_Txt.Text += result + "";
                    break;
                case 1: //subtract
                    result = (a - b);
                    calculations_Txt.Text = Convert.ToString(result);
                    a = b;
                    equation_Txt.Text += result + "";
                    break;
                case 2: //multiplicate
                    result = (a * b);
                    calculations_Txt.Text = Convert.ToString(result);
                    a = b;
                    equation_Txt.Text += result + "";
                    break;
                case 3: //divide
                    if (b == 0)
                    {
                        calculations_Txt.Text = "Cannot divide by zero";
                        equation_Txt.Text += "X";
                    }
                    else
                    {
                        result = (a / b);
                        calculations_Txt.Text = Convert.ToString(result);
                        a = b;
                        equation_Txt.Text += result + "";
                    }
                    break;
                default: break;
            }
        }
    }
}
