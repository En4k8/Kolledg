using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErrorProvider
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            nameBox.Validating += nameBox_Validating;
            numberBox.Validating += numberBox_Validating;
        }

        private void nameBox_Validating(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(nameBox.Text))
            {
                errorProvider1.SetError(nameBox, "Не указано имя!");
            }
            else if (nameBox.Text.Length < 4)
            {
                errorProvider1.SetError(nameBox, "Слишком короткое имя!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
        private void numberBox_Validating(object sender, EventArgs e)
        {
            int number = 0;
            if (String.IsNullOrEmpty(numberBox.Text))
            {
                errorProvider1.SetError(numberBox, "Не указан телефон!");
            }
            else if (!Int32.TryParse(numberBox.Text, out number))
            {
                errorProvider1.SetError(numberBox, "Некорретный телефон!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

    }
}
