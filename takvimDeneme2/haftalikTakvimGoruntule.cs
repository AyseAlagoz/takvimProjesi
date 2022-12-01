using business;
using entities;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace takvimDeneme2
{
    public partial class haftalikGoruntule : Form
    {
        public haftalikGoruntule()
        {
            InitializeComponent();
        }

        private void haftalikGoruntule_Load(object sender, EventArgs e)
        {
            Listele();
        }
        private void Listele()
        {
            businessLayer bL = new businessLayer();
            List<plans> liste = bL.haftalikListe();
            if (liste != null && liste.Count > 0)
            {
                    haftalikList.DataSource = liste;
            }
        }







    }
}
