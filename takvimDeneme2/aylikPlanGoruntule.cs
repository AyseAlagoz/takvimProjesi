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
    public partial class aylikPlanGoruntule : Form
    {
        public aylikPlanGoruntule()
        {
            InitializeComponent();
        }

        private void aylikPlanGoruntule_Load(object sender, EventArgs e)
        {
            Listele();
        }
        private void Listele()
        {
            businessLayer bL = new businessLayer();
            List<plans> liste = bL.planListe();
            if (liste != null && liste.Count > 0)
            {
                aylıkList.DataSource = liste;
            }
        }

        private void aylıkList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
