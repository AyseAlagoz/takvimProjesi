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
    public partial class anaForm : Form
    {
        public anaForm()
        {
            InitializeComponent();
        }

        private void btnAylik_Click(object sender, EventArgs e)
        {
            aylikPlanGoruntule aylikGoruntule = new aylikPlanGoruntule();
            aylikGoruntule.Show();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            aylıkTakvim aylik = new aylıkTakvim();
            aylik.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            haftalikGoruntule haftalikGoruntule = new haftalikGoruntule();
            haftalikGoruntule.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gunlukPlanGoruntule gunlukkGoruntule = new gunlukPlanGoruntule();
            gunlukkGoruntule.Show();
        }

        private void anaForm_Load(object sender, EventArgs e)
        {

        }
    }
    
}
