using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// doubleeraction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double a;
        string operation;

        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void addNum(double n)
        {
            calculations_Txt.Text += n;
        }

        // operations
        private void btn_C(object sender, RoutedEventArgs e)
        {
            calculations_Txt.Text = "";
            a = 0;
        }

        private void btn_devide(object sender, RoutedEventArgs e)
        {
            operation = "/";
            a = Convert.ToDouble(calculations_Txt.Text);
             calculations_Txt.Text = "";
        }

        private void btn_substract(object sender, RoutedEventArgs e)
        {
            
            operation = "-";
            a = Convert.ToDouble(calculations_Txt.Text);
             calculations_Txt.Text = "";
        }

        private void btn_sum(object sender, RoutedEventArgs e)
        {
            
            operation = "+";
            a = Convert.ToDouble(calculations_Txt.Text);
             calculations_Txt.Text = "";
        }

        private void btn_multiply(object sender, RoutedEventArgs e)
        {
            
            operation = "*";
            a = Convert.ToDouble(calculations_Txt.Text);
             calculations_Txt.Text = "";
        }

        private void btn_dott(object sender, RoutedEventArgs e)
        {
            calculations_Txt.Text += ".";
        }

        //enter numbers:
        double num;
        private void btn_7(object sender, RoutedEventArgs e)
        {
            num = 7;
            addNum(num);
        }

        private void btn_8(object sender, RoutedEventArgs e)
        {
            num = 8;
            addNum(num);
        }

        private void btn_9(object sender, RoutedEventArgs e)
        {
            num = 9;
            addNum(num);
        }

        private void btn_4(object sender, RoutedEventArgs e)
        {
            num = 4;
            addNum(num);
        }

        private void btn_5(object sender, RoutedEventArgs e)
        {
            num = 5;
            addNum(num);
        }

        private void btn_6(object sender, RoutedEventArgs e)
        {
            num = 6;
            addNum(num);
        }

        private void btn_1(object sender, RoutedEventArgs e)
        {
            num = 1;
            addNum(num);
        }

        private void btn_2(object sender, RoutedEventArgs e)
        {
            num = 2;
            addNum(num);
        }

        private void btn_3(object sender, RoutedEventArgs e)
        {
            num = 3;
            addNum(num);
        }

        private void btn_0(object sender, RoutedEventArgs e)
        {
            num = 0;
            addNum(num);
        }

        //calculate and print result
        private void btn_equal(object sender, RoutedEventArgs e)
        {
            double result;
            double b;

            b = Convert.ToDouble(calculations_Txt.Text);

            if (operation == "+")
            {
                result = (a + b);
                calculations_Txt.Text = Convert.ToString(result);
                a = b;
            }
            if (operation == "-")
            {
                result = (a - b);
                calculations_Txt.Text = Convert.ToString(result);
                a = b;
            }
            if (operation == "*")
            {
                result = (a * b);
                calculations_Txt.Text = Convert.ToString(result);
                a = b;
            }
            if (operation == "/")
            {
                if (b == 0)
                {
                    calculations_Txt.Text = "Cannot divide by zero";

                }
                else
                {
                    result = (a / b);
                    calculations_Txt.Text = Convert.ToString(result);
                    a = b;
                }
            }
        }
    }
}
