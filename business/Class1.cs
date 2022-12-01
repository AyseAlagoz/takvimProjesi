using dbLayer;
using entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static dbLayer.dataBase;

namespace business
{
    public class businessLayer
    {
        dataBase dB = new dataBase();

        public int planEkle(DateTime _tarih, string _plan)
        {
            return dB.planEkle(new plans()
            {
                Tarih = _tarih,
                Planlar = _plan,

            });
        }

        public List<plans> planListe()
        {
            List<plans> planListesi = new List<plans>();
            try
            {
                SqlDataReader reader = dB.planListe();
                while (reader.Read())
                {
                    planListesi.Add(new plans()
                    {
                        Tarih = reader.GetDateTime(0),
                        Planlar = reader.IsDBNull(1) ? String.Empty : reader.GetString(1),
                        
                    });
                }
                reader.Close();
            }
            catch (Exception)
            {

            }
            finally
            {
                dB.baglantiAyarla();
            }
            return planListesi;
        }

        public List<plans> haftalikListe()
        {
            List<plans> haftalikPlanListesi = new List<plans>();
            try
            {
                planListInput input = new planListInput();
                input.startdate = DateTime.Now.Date;
                input.finishdate = DateTime.Now.Date.AddDays(7);
                SqlDataReader reader = dB.haftalikListe(input);
                while (reader.Read())
                {
                    haftalikPlanListesi.Add(new plans()
                    {
                        Tarih = reader.GetDateTime(0),
                        Planlar = reader.IsDBNull(1) ? String.Empty : reader.GetString(1),
                    });
                }
                reader.Close();
            }
            catch (Exception)
            {

            }
            finally
            {
                dB.baglantiAyarla();
            }
            return haftalikPlanListesi;
        }

        public List<plans> gunlukListe()
        {
            List<plans> gunlukPlanListesi = new List<plans>();
            try
            {
                SqlDataReader reader = dB.gunlukListe(DateTime.Now.Date);
                while (reader.Read())
                {

                    gunlukPlanListesi.Add(new plans()
                    {
                        Tarih = reader.GetDateTime(0),
                        Planlar = reader.IsDBNull(1) ? String.Empty : reader.GetString(1),

                    });
                }
                reader.Close();
            }
            catch (Exception)
            {

            }
            finally
            {
                dB.baglantiAyarla();
            }
            return gunlukPlanListesi;
        }

    }
}
