using System;
using System.Collections.Generic;
using System.Globalization;
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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double firstNumber;
        double secondNumber;
        double equal;

        bool actButton = false;
        bool multipButton = false;
        bool divisButton = false;
        bool pluButton = false;
        bool minButton = false;
        bool moreact = false;

        public MainWindow()
        {
            InitializeComponent();
            textBox.IsReadOnly = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            textBox.Clear();
              actButton = false;
              multipButton = false;
              divisButton = false;
              pluButton = false;
              minButton = false;
             
        }

        private void FirstButton_Click(object sender, RoutedEventArgs e)
        {

            textBox.Text += firstButton.Content.ToString();

            if (!actButton)
                firstNumber = double.Parse(textBox.Text, CultureInfo.InvariantCulture);
            else
                secondNumber = double.Parse(textBox.Text, CultureInfo.InvariantCulture);
            
                 
        }

        private void SecondButton_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text += secondButton.Content.ToString();

            if (!actButton)
                firstNumber = double.Parse(textBox.Text, CultureInfo.InvariantCulture);
            else
                secondNumber = double.Parse(textBox.Text, CultureInfo.InvariantCulture);
        }



        private void NinthButton_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text += ninthButton.Content.ToString();

            if (!actButton)
                firstNumber = double.Parse(textBox.Text, CultureInfo.InvariantCulture);
            else
                secondNumber = double.Parse(textBox.Text, CultureInfo.InvariantCulture);
        }

        private void ThirdButton_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text += thirdButton.Content.ToString();

            if (!actButton)
                firstNumber = double.Parse(textBox.Text, CultureInfo.InvariantCulture);
            else
                secondNumber = double.Parse(textBox.Text, CultureInfo.InvariantCulture);

        }

        private void FourthBtton_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text += fourthButton.Content.ToString();

            if (!actButton)
                firstNumber = double.Parse(textBox.Text, CultureInfo.InvariantCulture);
            else
                secondNumber = double.Parse(textBox.Text, CultureInfo.InvariantCulture);

        }

        private void FifthButton_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text += fifthButton.Content.ToString();

            if (!actButton)
                firstNumber = double.Parse(textBox.Text, CultureInfo.InvariantCulture);
            else
                secondNumber = double.Parse(textBox.Text, CultureInfo.InvariantCulture);

        }

        private void SixthButton_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text += sixthButton.Content.ToString();

            if (!actButton)
                firstNumber = double.Parse(textBox.Text, CultureInfo.InvariantCulture);
            else
                secondNumber = double.Parse(textBox.Text, CultureInfo.InvariantCulture);

        }

        private void SeventhButton_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text += seventhButton.Content.ToString();

            if (!actButton)
                firstNumber = double.Parse(textBox.Text, CultureInfo.InvariantCulture);
            else
                secondNumber = double.Parse(textBox.Text, CultureInfo.InvariantCulture);

        }

        private void EightthButton_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text += eightthButton.Content.ToString();

            if (!actButton)
                firstNumber = double.Parse(textBox.Text, CultureInfo.InvariantCulture);
            else
                secondNumber = double.Parse(textBox.Text, CultureInfo.InvariantCulture);

        }

        private void ZeroButton_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text += zeroButton.Content.ToString();

            if (!actButton)
                firstNumber = double.Parse(textBox.Text, CultureInfo.InvariantCulture);
            else
                secondNumber = double.Parse(textBox.Text, CultureInfo.InvariantCulture);

        }

        private void PointButton_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text += pointButton.Content.ToString();

            if (!actButton)
                firstNumber = double.Parse(textBox.Text, CultureInfo.InvariantCulture);
            else
                secondNumber = double.Parse(textBox.Text, CultureInfo.InvariantCulture);

        }

        private void PlusButton_Click(object sender, RoutedEventArgs e)
        {
            multipButton = false;
            divisButton = false;
            pluButton = false;
            minButton = false;

            if (String.IsNullOrEmpty(textBox.Text))
            {
                MessageBox.Show("Enter the number!");
            }
            else
            {
                pluButton = true;
                if (actButton)
                {
                    try
                    {
                        firstNumber = double.Parse(textBox.Text, CultureInfo.InvariantCulture);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message);
                    }
                }
                
                actButton = true;
                
                textBox.Clear();
                
            }
        }

        private void DivButton_Click(object sender, RoutedEventArgs e)
        {
            multipButton = false;
            divisButton = false;
            pluButton = false;
            minButton = false;
            if (String.IsNullOrEmpty(textBox.Text))
            {
                MessageBox.Show("Enter the number!");
            }
            else
            {
                divisButton = true;
                if (actButton)
                {
                    try
                    {
                        firstNumber = double.Parse(textBox.Text, CultureInfo.InvariantCulture);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message);
                    }
                }
                actButton = true;
                textBox.Clear();
            }
        }

        private void MultButton_Click(object sender, RoutedEventArgs e)
        {
            multipButton = false;
            divisButton = false;
            pluButton = false;
            minButton = false;
            if (String.IsNullOrEmpty(textBox.Text))
            {
                MessageBox.Show("Enter the number!");
            }
            else
            {
                
                multipButton = true;
                if (actButton)
                {
                    try
                    {
                        firstNumber = double.Parse(textBox.Text, CultureInfo.InvariantCulture);
                    }
                    catch (Exception exception) {
                        MessageBox.Show(exception.Message);
                    }

                }
                actButton = true;
                textBox.Clear();
            }
        }

        private void MinusButton_Click(object sender, RoutedEventArgs e)
        {
            multipButton = false;
            divisButton = false;
            pluButton = false;
            minButton = false;
            if (String.IsNullOrEmpty(textBox.Text))
            {
                MessageBox.Show("Enter the number!");
            }
            else
            {
                minButton = true;
                if (actButton)
                {
                    try
                    {
                        firstNumber = double.Parse(textBox.Text, CultureInfo.InvariantCulture);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message);
                    }
                }
                actButton = true;
                textBox.Clear();
            }
        }

        private void EqualButton_Click(object sender, RoutedEventArgs e)
        {
            textBox.Clear();
            if (minButton)
            {
                equal = firstNumber - secondNumber;
            }
            else if (pluButton)
            {
                equal = firstNumber + secondNumber;

            }
            else if (multipButton) {
                equal = firstNumber * secondNumber;

            }
            else if (divisButton)
            {
                equal = firstNumber / secondNumber;

            }

            textBox.Text = equal.ToString();

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
