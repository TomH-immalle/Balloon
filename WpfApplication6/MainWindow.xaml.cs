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

namespace WpfApplication6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Ellipse ellip = new Ellipse();
        

        public MainWindow()
        {
            InitializeComponent();
            ellip.Width = 130;
            ellip.Height = 130;
            ellip.Margin = new Thickness(100, 100, 0, 0);
            ellip.Stroke = new SolidColorBrush(Colors.Red);
            canvas.Children.Add(ellip);
           
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            ellip.Width = ellip.Width + 10;
            ellip.Height += 10;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            
            ellip.Margin = new Thickness(ellip.Margin.Left, ellip.Margin.Top -10, ellip.Margin.Right, ellip.Margin.Bottom +10);
           
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            ellip.Width -= 10;
            ellip.Height -= 10;
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            ellip.Margin = new Thickness(ellip.Margin.Left, ellip.Margin.Top + 10, ellip.Margin.Right, ellip.Margin.Bottom - 10);
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            ellip.Width = 130;
            ellip.Height = 130;
            ellip.Margin = new Thickness(100, 100, 0, 0);
            ellip.Stroke = new SolidColorBrush(Colors.Red);
        }
    }
}
