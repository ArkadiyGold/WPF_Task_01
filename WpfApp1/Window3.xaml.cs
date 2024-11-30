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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }
    
        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            ImageBox.Source = new BitmapImage(new Uri(@"C:\Users\VanishevArkadiy\photo_5384322765391253987_y.jpg"));
        }

        private void ComboBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {
            ImageBox.Source = new BitmapImage(new Uri(@"C:\Users\VanishevArkadiy\devil-may-cry-5-dante-vs-vergil-uhdpaper.com-hd-6.3105.jpg"));
        }

        private void ComboBoxItem_Selected_2(object sender, RoutedEventArgs e)
        {
            ImageBox.Source = new BitmapImage(new Uri(@"C:\Users\VanishevArkadiy\dark-souls-iii-artwork-video-games-gothic-wallpaper-preview.jpg"));
        }
    }
}
