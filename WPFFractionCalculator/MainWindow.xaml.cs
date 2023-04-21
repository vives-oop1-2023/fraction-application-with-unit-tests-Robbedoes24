using FractionLibrary;
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

namespace WPFFractionCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ChangeButtonBackgrounds();
            ChangeContent();
            //UpdateMessageBoard("");
        }

        void OnClickOperator(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            activeButton = button.Name;

            ChangeButtonBackgrounds();
            ChangeContent();

        }

        void ChangeButtonBackgrounds()
        {
            // define colors
            SolidColorBrush activeBackground = Brushes.Green;
            SolidColorBrush activeBorder = Brushes.DarkGreen;
            SolidColorBrush inactiveBackground = Brushes.DeepSkyBlue;
            SolidColorBrush inactiveBorder = Brushes.DeepSkyBlue;

            // set all button backgrounds to orange
            add.Background = inactiveBackground;
            add.BorderBrush = inactiveBorder;

            subtract.Background = inactiveBackground;
            subtract.BorderBrush = inactiveBorder;

            multiply.Background = inactiveBackground;
            multiply.BorderBrush = inactiveBorder;

            divide.Background = inactiveBackground;
            divide.BorderBrush = inactiveBorder;

            invert.Background = inactiveBackground;
            invert.BorderBrush = inactiveBorder;

            reciprocal.Background = inactiveBackground;
            reciprocal.BorderBrush = inactiveBorder;

            simplify.Background = inactiveBackground;
            simplify.BorderBrush = inactiveBorder;

            // set background of the selected button to green
            switch (activeButton)
            {
                case "add":
                    add.Background = activeBackground;
                    add.BorderBrush = activeBorder;
                    break;

                case "subtract":
                    subtract.Background = activeBackground;
                    subtract.BorderBrush = activeBorder;
                    break;

                case "multiply":
                    multiply.Background = activeBackground;
                    multiply.BorderBrush = activeBorder;
                    break;

                case "divide":
                    divide.Background = activeBackground;
                    divide.BorderBrush = activeBorder;
                    break;

                case "invert":
                    invert.Background = activeBackground;
                    invert.BorderBrush = activeBorder;
                    break;

                case "reciprocal":
                    reciprocal.Background = activeBackground;
                    reciprocal.BorderBrush= activeBorder;
                    break;

                case "simplify":
                    simplify.Background = activeBackground;
                    simplify.BorderBrush = activeBorder;
                    break;

                default:
                    add.Background = activeBackground;
                    add.BorderBrush= activeBorder;
                    break;
            }

        }

        void ChangeContent()
        {
            // Set default visibility to visible and spacing
            operation.Visibility = Visibility.Visible;
            content.ColumnDefinitions[0].Width = new GridLength(1.0, GridUnitType.Star);
            fraction1_grid.Visibility = Visibility.Visible;

            // set the text of 
            switch (activeButton)
            {
                case "add":
                    operation.Text = "+";
                    break;

                case "subtract":
                    operation.Text = "-";
                    break;

                case "multiply":
                    operation.Text = "*";
                    break;

                case "divide":
                    operation.Text = "/";
                    break;

                case "invert":
                    operation.Text= "-";
                    content.ColumnDefinitions[0].Width = GridLength.Auto;
                    fraction1_grid.Visibility= Visibility.Collapsed;
                    break;

                case "reciprocal":
                    operation.Visibility = Visibility.Collapsed;
                    content.ColumnDefinitions[0].Width = GridLength.Auto;
                    fraction1_grid.Visibility = Visibility.Collapsed;
                    break;

                case "simplify":
                    operation.Visibility = Visibility.Collapsed;
                    content.ColumnDefinitions[0].Width = GridLength.Auto;
                    fraction1_grid.Visibility = Visibility.Collapsed;
                    break;

                default:
                    operation.Text = "+";
                    break;
            }
        }

        void OnClickSolve(object sender, RoutedEventArgs e) 
        {
            bool validInput = ValidUserInput(sender, e);

            if (validInput)
            {
                // Creating the fraction objects
                Fraction f1 = new Fraction();
                Fraction f2 = new Fraction();
                Fraction solution = new Fraction();

                try
                {
                    f1.Numerator = Convert.ToInt32(fraction1_numerator.Text);
                    f1.Denominator = Convert.ToInt32(fraction1_denominator.Text);
                }
                catch { } // no errorhandling yet (if nothing or wrong value is filled in will return 1/1 for f1)

                try
                {
                    f2.Numerator = Convert.ToInt32(fraction2_numerator.Text);
                    f2.Denominator = Convert.ToInt32(fraction2_denominator.Text);
                }
                catch { } // no errorhandling yet (if nothing or wrong value is filled in will return 1/1 for f2)

                switch (activeButton)
                {
                    case "add":
                        solution = f1.Add(f2).Simplify();
                        break;

                    case "subtract":
                        solution = f1.Subtract(f2).Simplify();
                        break;

                    case "multiply":
                        solution = f1.Multiply(f2).Simplify();
                        break;

                    case "divide":
                        solution = f1.Divide(f2).Simplify();
                        break;

                    case "invert":
                        solution = f2.Invert().Simplify();
                        break;

                    case "reciprocal":
                        solution = f2.Reciprocal().Simplify();
                        break;

                    case "simplify":
                        solution = f2.Simplify();
                        break;

                    default:
                        break;
                }

                solution_numerator.Text = solution.Numerator.ToString();
                solution_denominator.Text = solution.Denominator.ToString();
            }
            else
            {
                solution_numerator.Text = "";
                solution_denominator.Text = "";
            }
        }

        bool ValidUserInput(object sender, RoutedEventArgs e)
        {
            // default state
            UpdateMessageBoard("");

            // check if string is valid
            bool Valid(string input, bool denominator)
            {
                // because the tryparse needs an out
                int i;
                if(input == "" || input.Contains(".") || input.Contains(".") || !int.TryParse(input, out i))
                {
                    return false;
                }
                if(denominator && i == 0)
                {
                    return false;
                }

                return true;
            }

            switch (activeButton)
            {
                case "invert": case "reciprocal": case "simplify":
                    if (!Valid(fraction2_numerator.Text, false))
                    {
                        UpdateMessageBoard("The input for the numerator of the fraction is in Invalid");
                        return false;
                    }
                    if (!Valid(fraction2_denominator.Text, true))
                    {
                        UpdateMessageBoard("The input for the denominator of the fraction is in Invalid");
                        return false;
                    }
                    break;

                default:
                    if (!Valid(fraction1_numerator.Text, false))
                    {
                        UpdateMessageBoard("The input for the numerator of fraction 1 is in Invalid");
                        return false;
                    }
                    if (!Valid(fraction1_denominator.Text, true))
                    {
                        UpdateMessageBoard("The input for the denominator of fraction 1 is in Invalid");
                        return false;
                    }
                    if (!Valid(fraction2_numerator.Text, false))
                    {
                        UpdateMessageBoard("The input for the numerator of fraction 2 is in Invalid");
                        return false;
                    }
                    if (!Valid(fraction2_denominator.Text, true))
                    {
                        UpdateMessageBoard("The input for the denominator of fraction 2 is in Invalid");
                        return false;
                    }
                    break;
            }
            return true;
        }

        void OnClickClear(object sender, RoutedEventArgs e)
        {
            // clear value in fraction 1 textboxes
            fraction1_numerator.Text = "";
            fraction1_denominator.Text = "";

            // clear value in fraction 2 textboxes
            fraction2_numerator.Text = "";
            fraction2_denominator.Text = "";

            // clear value in solution textboxes
            solution_numerator.Text = "";
            solution_denominator.Text = "";

            // reset messageBoard
            UpdateMessageBoard("");
        }

        void UpdateMessageBoard(string text)
        {
            if (text == "")
            {
                messageBoard.Visibility = Visibility.Collapsed;
            }
            else
            {
                messageBoard.Visibility = Visibility.Visible;
            }
            messageBoard.Text = text;
        }

        private string activeButton = "add";
    }
}
