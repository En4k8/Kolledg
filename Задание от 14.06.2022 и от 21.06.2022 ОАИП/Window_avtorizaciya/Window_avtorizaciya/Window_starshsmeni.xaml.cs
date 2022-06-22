using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Window_avtorizaciya
{
    /// <summary>
    /// Логика взаимодействия для Window_starshsmeni.xaml
    /// </summary>
    public partial class Window_starshsmeni : Window
    {
        public Window_starshsmeni()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainwin = new MainWindow();
            mainwin.Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window_Oformlenie_zakaza oformleniezakaza = new Window_Oformlenie_zakaza();
            oformleniezakaza.Show();
        }
    }
}
