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

namespace Window_avtorizaciya
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
            MessageBox.Show("Данные для входа\nАдмин: Логин - Admin, Пароль - Admin\nСтарший смены: Логин - Smena123, Пароль - Smena123\nПродавец: Логин - Tovar123, Пароль - Tovar123","Помощь");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            string[] logins = new string[3] { "Admin", "Smena123", "Tovar123" };
            string[] password = new string[3] { "Admin", "Smena123", "Tovar123" };
            if (Text_login.Text.Equals(logins[0]) & Text_password.Text.Equals(password[0]))
            {
                MessageBox.Show("Вы зашли за Администратора");
                Window_admin winadmin = new Window_admin();
                winadmin.Show();
                Close();
            }
            else if (Text_login.Text.Equals(logins[1]) & Text_password.Text.Equals(password[1]))
            {
                MessageBox.Show("Вы зашли за Старшего смены");
                Window_starshsmeni winstarshsmeny = new Window_starshsmeni();
                winstarshsmeny.Show();
                Close();
            }
            else if (Text_login.Text.Equals(logins[2]) & Text_password.Text.Equals(password[2]))
            {
                MessageBox.Show("Вы зашли за продавца");
                Window_prodavec winprodavec = new Window_prodavec();
                winprodavec.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль. Попробуйте снова.");
            }

        }
    }
}
