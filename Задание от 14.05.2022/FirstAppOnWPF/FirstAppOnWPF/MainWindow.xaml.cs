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

namespace FirstAppOnWPF
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
            string name = textBox1.Text;
            string lastname = textBox2.Text;
            string patronymic = textBox3.Text;
            string number = textBox4.Text;
            string email = textBox5.Text;
            string address = textBox6.Text;
            MessageBox.Show("Ваше имя:" + ""+ name + "\n"+
                            "Ваша фамилия: " + "" + lastname + "\n" +
                            "Ваше отчество: " + "" + patronymic + "\n" +
                            "Ваш номер: " + "" + number + "\n" +
                            "Ваша почта: " + "" + email + "\n" +
                            "Ваш адрес: " + "" + address +"","Вывод формы");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            MessageBox.Show("Все поля очищены");
        }
    }
}
