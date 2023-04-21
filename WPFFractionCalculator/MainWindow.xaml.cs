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
            frame.NavigationService.Navigate(calculatorPage);
        }

        void OnAboutClick(object sender, RoutedEventArgs e)
        {
            if (frame.NavigationService.Content is CalculatorPage)
            {
                frame.NavigationService.Navigate(aboutPage);
                about.Content = "Calculator";
            }
            else
            {
                frame.NavigationService.Navigate(calculatorPage);
                about.Content = "About";
            }
        }

        private readonly AboutPage aboutPage = new AboutPage();
        private readonly CalculatorPage calculatorPage = new CalculatorPage();
    }
}
