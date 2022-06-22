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
    /// Логика взаимодействия для Window_admin.xaml
    /// </summary>
    public partial class Window_admin : Window
    {
        public Window_admin()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainwin = new MainWindow();
            mainwin.Show();
            Close();
        }
    }
}
