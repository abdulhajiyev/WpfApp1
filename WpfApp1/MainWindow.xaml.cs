using System;
using System.Runtime.Remoting.Channels;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Random Random { get; set; } = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }


        private SolidColorBrush CreateColor()
        {

            var r = Convert.ToByte(Random.Next(0, 255));
            var g = Convert.ToByte(Random.Next(0, 255));
            var b = Convert.ToByte(Random.Next(0, 255));

            return new SolidColorBrush(Color.FromRgb(r, g, b));
        }

        private void Button_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Button btn = sender as Button;
            btn.Background = CreateColor();
            MessageBox.Show(btn.Content.ToString());
        }

        private void Button_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Button btn = sender as Button;
            BtnGrid.Children.Remove(btn);
            Title += btn.Content.ToString();
        }

        private void Btn_Load(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            btn.Background = CreateColor();
        }
    }
}
