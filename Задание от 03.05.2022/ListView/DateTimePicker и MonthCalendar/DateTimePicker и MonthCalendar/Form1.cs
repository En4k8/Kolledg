using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimePicker_и_MonthCalendar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;

            monthCalendar1.AddBoldedDate(new DateTime(2022, 05, 21));
            monthCalendar1.AddBoldedDate(new DateTime(2022, 05, 22));
            monthCalendar1.AddAnnuallyBoldedDate(new DateTime(2022, 05, 9));
            monthCalendar1.AddMonthlyBoldedDate(new DateTime(2022, 05, 1));
            monthCalendar1.ShowTodayCircle = true;
            monthCalendar1.ShowToday = true;
            monthCalendar1.SelectionStart = new DateTime(2022, 05, 1);
            monthCalendar1.SelectionEnd = new DateTime(2022, 05, 11);

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = String.Format("Вы выбрали: {0}", dateTimePicker1.Value.ToLongDateString());
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            label2.Text = String.Format("Вы выбрали: {0}", monthCalendar1.SelectionStart.ToLongDateString());
        }
    }
}
