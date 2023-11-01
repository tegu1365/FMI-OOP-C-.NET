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

namespace CalculatorSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Data Memebers
        private double firstNumber;
        private double secondNumber;
        private double result;
        private enum Operation
        {
            NO_OPERATION, ADDITION, SUBTRACTION,
            DIVISION, MULTIPLICATION
        };
        private Operation operation;
        #endregion
        #region Constuctor
        public MainWindow()
        {
            InitializeComponent();
            operation = Operation.NO_OPERATION;
        } 
        #endregion

        private void BtnOff_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        /// <summary>
        /// Event handler for digit click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Digit_Click(object sender, RoutedEventArgs e)
        {
            var digit = ((Button)sender).Content.ToString();
            if (digit == ".") digit = ",";

            if(TxtInput.Text == "0") 
            {
                if(digit == ",") { TxtInput.Text = $"{TxtInput.Text}{digit}"; }
                else TxtInput.Text = digit;
            }
            else
            {
                if(digit=="," && TxtInput.Text.Contains(",")) { return; }
                TxtInput.Text= $"{TxtInput.Text}{digit}";
            }
        }

        private void Operation_Click(object sender, RoutedEventArgs e)
        {
            //read first number
            if(!double.TryParse(TxtInput.Text, out firstNumber))
            {
                MessageBox.Show("Wrong input. Try again...");
                TxtInput.Text = "0";
                return;
            }
            //read current operation
            string operationSign = ((Button) sender).Content.ToString()!;

            operation = operationSign switch
            {
                "+" => Operation.ADDITION,
                "-" => Operation.SUBTRACTION,
                "x" => Operation.MULTIPLICATION,
                "/" => Operation.DIVISION,
                _ => Operation.NO_OPERATION
            };
            //init input box
            TxtInput.Text = "0";

        }

        private void Compute_Click(object sender, RoutedEventArgs e)
        {
            //read second number
            if (!double.TryParse(TxtInput.Text, out secondNumber))
            {
                MessageBox.Show("Wrong input. Try again...");
                TxtInput.Text = "0";
                return;
            }
            //Compute selected operation
            result = operation switch
            {
                Operation.ADDITION => firstNumber + secondNumber,
                Operation.SUBTRACTION => firstNumber - secondNumber,
                Operation.MULTIPLICATION => firstNumber * secondNumber,
                Operation.DIVISION => firstNumber / secondNumber,
                _=>0
            };
            //display
            operation = Operation.NO_OPERATION;
            TxtInput.Text=""+result;
        }
    }
}
