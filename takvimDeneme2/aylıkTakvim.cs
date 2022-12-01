using business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace takvimDeneme2
{
    public partial class aylıkTakvim : Form
    {
        int month, year;

        public static int static_month, static_year;
        public aylıkTakvim()
        {
            InitializeComponent();
        }

        private void aylıkTakvim_Load(object sender, EventArgs e)
        {
            days();
        }

        private void days()
        {
            DateTime now = DateTime.Now;

            month = now.Month;
            year = now.Year;

            string montName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblHangiAyYil.Text = montName + " " + year;

            static_month = month;
            static_year = year;

            DateTime startofthemonth = new DateTime(year, month, 1);

            int daysCount = DateTime.DaysInMonth(year, month);

            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank userControl = new UserControlBlank();
                dayContainer.Controls.Add(userControl);
            }

            for (int i = 1; i <= daysCount; i++)
            {
                UserControlDays daysControl = new UserControlDays();
                daysControl.days(i);
                dayContainer.Controls.Add(daysControl);
            }
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dayContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblHangiAyYil_Click(object sender, EventArgs e)
        {

        }

        private void buttonÖnceki_Click(object sender, EventArgs e)
        {
            dayContainer.Controls.Clear();

            month--;

            static_month = month;
            static_year = year;

            string montName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblHangiAyYil.Text = montName + " " + year;


            DateTime startofthemonth = new DateTime(year, month, 1);

            int daysCount = DateTime.DaysInMonth(year, month);

            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank userControl = new UserControlBlank();
                dayContainer.Controls.Add(userControl);
            }

            for (int i = 1; i <= daysCount; i++)
            {
                UserControlDays daysControl = new UserControlDays();
                daysControl.days(i);
                dayContainer.Controls.Add(daysControl);
            }
        }

        private void buttonSonraki_Click(object sender, EventArgs e)
        {
            dayContainer.Controls.Clear();

            month++;

            static_month = month;
            static_year = year;

            string montName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblHangiAyYil.Text = montName + " " + year;


            DateTime startofthemonth = new DateTime(year, month, 1);

            int daysCount = DateTime.DaysInMonth(year, month);

            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank userControl = new UserControlBlank();
                dayContainer.Controls.Add(userControl);
            }

            for (int i = 1; i <= daysCount; i++)
            {
                UserControlDays daysControl = new UserControlDays();
                daysControl.days(i);
                dayContainer.Controls.Add(daysControl);
            }
        }
    }
}
