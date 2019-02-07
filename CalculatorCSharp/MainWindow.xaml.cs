using System;
using System.Windows;
using System.Windows.Controls;

namespace CalculatorCSharp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        double firstNum;
        double secNum;
        double result;
        string arithOp;
        bool isResult = false;

        private void BtnDigit_Click(object sender, RoutedEventArgs e)
        {
            Button numbers = sender as Button;
            if (!isResult)
            {
                if (txtBoxDisplay.Text == "0")
                {
                    txtBoxDisplay.Text = numbers.Content.ToString();
                }
                else
                {
                    txtBoxDisplay.Text += numbers.Content.ToString();
                }
            }
            else
            {
                txtBlockShow.Text = "";
                txtBoxDisplay.Text = numbers.Content.ToString();
                isResult = false;
            }
        }

        private void BtnBckSpc_Click(object sender, RoutedEventArgs e)
        {
            txtBoxDisplay.Text = txtBoxDisplay.Text.Length >= 1 ? txtBoxDisplay.Text.Remove(txtBoxDisplay.Text.Length - 1, 1) : "0";
            if (txtBoxDisplay.Text.Length == 0)
                txtBoxDisplay.Text = "0";
        }

        private void BtnClean_Click(object sender, RoutedEventArgs e)
        {
            firstNum = 0;
            secNum = 0;
            result = 0;
            txtBoxDisplay.Text = "0";
            txtBlockShow.Text = "";
            arithOp = "";
            isResult = false;
        }

        private void BtnCleanEntry_Click(object sender, RoutedEventArgs e)
        {
            txtBoxDisplay.Text = "0";
        }

        private void BtnArithOp_Click(object sender, RoutedEventArgs e)
        {
            Button op = sender as Button;
            firstNum = double.Parse(txtBoxDisplay.Text);
            txtBlockShow.Text = txtBoxDisplay.Text + op.Content.ToString();
            arithOp = op.Content.ToString();
            isResult = true;
        }

        private void BtnDot_Click(object sender, RoutedEventArgs e)
        {
            if(!txtBoxDisplay.Text.Contains(","))
            {
                txtBoxDisplay.Text = $"{txtBoxDisplay.Text},";
            }
        }

        private void BtnNegative_Click(object sender, RoutedEventArgs e)
        {
            if (!txtBoxDisplay.Text.Contains("-"))
            {
                txtBoxDisplay.Text = $"-{txtBoxDisplay.Text}";
            }
            else
            {
                txtBoxDisplay.Text = txtBoxDisplay.Text.Remove(0, 1);
            }
        }

        private void BtnResult_Click(object sender, RoutedEventArgs e)
        {
            if (!isResult)
                secNum = double.Parse(txtBoxDisplay.Text);
            if (arithOp == "+")
            {
                result = firstNum + secNum;
                txtBoxDisplay.Text = result.ToString();
                txtBlockShow.Text = "";
                //listBoxJournal->Items->Add(firstNum + " + " + secondNum + " = " + result);
                firstNum = result;
                isResult = true;
            }
            else if (arithOp == "-")
            {
                result = firstNum - secNum;
                txtBoxDisplay.Text = result.ToString();
                txtBlockShow.Text = "";
                //listBoxJournal->Items->Add(firstNum + " - " + secondNum + " = " + result);
                firstNum = result;
                isResult = true;
            }
            else if (arithOp == "*")
            {
                result = firstNum * secNum;
                txtBoxDisplay.Text = result.ToString();
                txtBlockShow.Text = "";
                //listBoxJournal->Items->Add(firstNum + " * " + secondNum + " = " + result);
                firstNum = result;
                isResult = true;
            }
            else if (arithOp == "/")
            {
                if (txtBoxDisplay.Text == "0")
                {
                    MessageBox.Show("Деление на ноль!!!");
                }
                else
                {
                    result = firstNum / secNum;
                    txtBoxDisplay.Text = result.ToString();
                    //listBoxJournal->Items->Add(firstNum + "/" + secondNum + " = " + result);
                    txtBlockShow.Text = "";
                    firstNum = result;
                    isResult = true;
                }
            }
        }

        private void BtnSqrt_Click(object sender, RoutedEventArgs e)
        {
            if (!txtBoxDisplay.Text.Contains("-"))
            {
                firstNum = double.Parse(txtBoxDisplay.Text);
                txtBoxDisplay.Text = Math.Sqrt(firstNum).ToString();
                //listBoxJournal->Items->Add("sqr" + "(" + firstNum + ")" + " = " + textBox1->Text);
                txtBlockShow.Text = $"sqrt({firstNum})";
                isResult = true;
            }
            else
            {
                MessageBox.Show("Не корректные данные!!!");
            }
        }

        private void BtnSqr_Click(object sender, RoutedEventArgs e)
        {
            firstNum = double.Parse(txtBoxDisplay.Text);
            txtBoxDisplay.Text = Math.Pow(firstNum, 2).ToString();
            //listBoxJournal->Items->Add("sqr" + "(" + firstNum + ")" + " = " + textBox1->Text);
            txtBlockShow.Text = $"sqr({firstNum})";
            isResult = true;
        }

        private void BtnCube_Click(object sender, RoutedEventArgs e)
        {
            firstNum = double.Parse(txtBoxDisplay.Text);
            txtBoxDisplay.Text = Math.Pow(firstNum, 3).ToString();
            //listBoxJournal->Items->Add("cube" + "(" + firstNum + ")" + " = " + textBox1->Text);
            txtBlockShow.Text = $"cube({firstNum})";
            isResult = true;
        }

        private void BtnDivX_Click(object sender, RoutedEventArgs e)
        {
            if (txtBoxDisplay.Text == "0")
            {
                MessageBox.Show("Деление на ноль!!!");
            }
            else
            {
                firstNum = double.Parse(txtBoxDisplay.Text);
                txtBoxDisplay.Text = (1 / firstNum).ToString();
                //listBoxJournal->Items->Add("1/" + firstNum + " = " + textBox1->Text);
                txtBlockShow.Text = $"1/{firstNum}";
                isResult = true;
            }
        }
    }
}
