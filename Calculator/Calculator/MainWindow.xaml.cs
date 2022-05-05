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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public double inputOne = 0.00;
        public double inputTwo = 0.00;
        public string C_operator = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void text_input_field_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void text_input_field_GotFocus(object sender, RoutedEventArgs e)
        {
            if (text_input_field.Text == "0")
            {
                text_input_field.Text = "";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Calculate();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            inputOne = 0.00;
            inputTwo = 0.00;
            C_operator = "";
            text_input_field.Text = "";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            SetOperator();
            C_operator = "%";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            SetOperator();
            C_operator = "/";
        }

        private void SetOperator()
        {
            if (C_operator != null && C_operator.Length > 0)
            {
                if (inputTwo > 0)
                {
                    Calculate();
                }
            }
        }

        private void Calculate()
        {

            double result = 0.00;
            if (C_operator == "+")
            {
                result = inputOne + inputTwo;
            }
            else if (C_operator == "-")
            {
                result = inputOne - inputTwo;
            }
            else if (C_operator == "/")
            {
                result = inputOne / inputTwo;
            }
            else if (C_operator == "*")
            {
                result = inputOne * inputTwo;
            }
            else if (C_operator == "%")
            {
                result = inputOne * inputTwo * 0.01;
            }
            text_input_field.Text = "" + result;
            C_operator = "";
            inputOne = result;
            inputTwo = 0;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            SetOperator();
            C_operator = "*";
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            SetOperator();
            C_operator = "-";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            SetOperator();
            C_operator = "+";
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            SetDisplay("1");

        }

        private void SetDisplay(string v)
        {
            string currentDisplay = text_input_field.Text;
            string oldText;
            if (C_operator != null && C_operator.Length > 0)
            {
                if (currentDisplay.Contains(".") && inputTwo>0 && !inputTwo.ToString().Contains("."))
                {
                    oldText = (inputTwo == 0 ? "" : "" + inputTwo) + "." + v;

                }
                else
                {
                    oldText = (inputTwo == 0 ? "" : "" + inputTwo) + v;

                }
                inputTwo = Convert.ToDouble(oldText);
            }
            else
            {
                if (currentDisplay.Contains(".") && !inputOne.ToString().Contains("."))
                {
                    oldText = (inputOne == 0 ? "" : "" + inputOne) + "." + v;

                }
                else
                {
                    oldText = (inputOne == 0 ? "" : "" + inputOne) + v;


                }
                inputOne = Convert.ToDouble(oldText);
            }
            text_input_field.Text = oldText;
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            SetDisplay("2");
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            SetDisplay("3");
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            SetDisplay("4");
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            SetDisplay("5");
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            SetDisplay("6");
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            SetDisplay("7");
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            SetDisplay("8");
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            SetDisplay("9");
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            SetDisplay("0");
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            string oldText = text_input_field.Text;
            text_input_field.Text = oldText + ".";
        }

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {
            string oldText = text_input_field.Text;
            if (oldText != null && oldText.Length > 0)
            {
                oldText = oldText.Substring(0, oldText.Length - 1);
            }
            if (oldText != null && oldText.Length < 1)
            {
                oldText = "0";
            }
            if (oldText.Length > 0)
            {

                if (C_operator != null && C_operator.Length > 0)
                {


                    inputTwo = Convert.ToDouble(oldText);
                }
                else
                {

                    inputOne = Convert.ToDouble(oldText);
                }

                text_input_field.Text = oldText;
            }
        }
    }
}
