using business;
using entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace takvimDeneme2
{
    public partial class UserControlDays : UserControl
    {
        public static string static_days;
        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {
            
        }

        public void days(int numdays)
        {
            lblDays.Text = numdays.ToString();
           
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            static_days = lblDays.Text;
            planEkleme uplanekleme = new planEkleme();
            uplanekleme.Show();
        }


        private void lblPlan_Click(object sender, EventArgs e)
        {

        }

        private void lblDays_Click(object sender, EventArgs e)
        {

        }

    }
}
