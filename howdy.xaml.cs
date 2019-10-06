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

namespace HowAreYou
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(GreatButton.IsChecked == true)
            {
                MessageBox.Show("Great, that is good to hear.");
            }
            else if(GoodButton.IsChecked == true)
            {
                MessageBox.Show("That is nice to hear that.");
            }
            else if(OkayButton.IsChecked == true)
            {
                MessageBox.Show("I'm sorry to hear.");
            }
            else if(BadButton.IsChecked == true)
            {
                MessageBox.Show("Oh, I'm sorry to hear that.");
            }
        }
    }
}
