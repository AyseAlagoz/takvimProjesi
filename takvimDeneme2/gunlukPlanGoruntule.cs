using business;
using entities;
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
    public partial class gunlukPlanGoruntule : Form
    {
        public gunlukPlanGoruntule()
        {
            InitializeComponent();
        }

        private void gunlukList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gunlukPlanGoruntule_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            businessLayer bL = new businessLayer();
            List<plans> liste = bL.gunlukListe();
            if (liste != null && liste.Count > 0)
            {
                gunlukList.DataSource = liste;
            }
        }
    }
}
