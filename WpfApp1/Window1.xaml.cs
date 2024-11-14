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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private string _pass = "1243567890";
        private string _inputPass = "";
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello world.");
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }
        private void Button_Click_2(object sender, RoutedEventArgs)
        {
            _inputPass = pswdTxt.Password;
            if(_inputPass == _pass)
            {
                txtDisplay.Text = "Welcum.";
            }
            else
            {
                MessageBox.Show("Nope.");
            }
        }
    }
}
