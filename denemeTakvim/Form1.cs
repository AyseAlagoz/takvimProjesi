using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace denemeTakvim
{
    public partial class aylıkTablo : Form
    {
        public aylıkTablo()
        {
            InitializeComponent();
        }

        private void aylıkTablo_Load(object sender, EventArgs e)
        {

        }

        private void days()
        {
            DateTime now = DateTime.Now;

            DateTime startofthemonth = new DateTime(now.Year, now.Month,1);

            int daysCount = DateTime.DaysInMonth(now.Year, now.Month);

            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));


        }
    }
}
