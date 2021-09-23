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

namespace Conditional_And_Logic_Assignment
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            labelEqual.Content = "Greater Than";
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //labelResult.Content = (textBox1.Text == textBox2.Text) ? "Yes" : "No";

            //labelResult.Content = (checkBox.IsChecked == true) ? "Why'd you check my box!?" : "Good. Don't check my box.";

            //labelResult.Content = (textBox1.Text != textBox2.Text) ? "Yes" : "No";

            //int numOne = Convert.ToInt32(textBox1.Text);
            //int numTwo = Convert.ToInt32(textBox2.Text);

            //labelResult.Content = (numOne >= numTwo) ? "Yes" : "No";

            //=< less than or equal to

            //if ((textBox1.Text == "Smith")||(textBox2.Text == "Wilson"))
            //{
            //    labelResult.Content = "Good Morning";
            //}
            //else
            //{
            //    labelResult.Content = "Who are you?";
            //}



        }
    }
}
