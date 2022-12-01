using business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace takvimDeneme2
{
    public partial class planEkleme : Form
    {
        public planEkleme()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void planEkleme_Load(object sender, EventArgs e)
        {
            txtTarih.Text = aylıkTakvim.static_month + "/" + UserControlDays.static_days + "/" + aylıkTakvim.static_year;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            businessLayer bL = new businessLayer();
            bL.planEkle(Convert.ToDateTime(txtTarih.Text), Convert.ToString(txtPlan.Text));

            MessageBox.Show("Plan Kaydedildi");
        }

        private void txtTarih_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
