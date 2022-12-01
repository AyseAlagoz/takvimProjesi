using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace denemeTakvim
{
    public class businessDeneme
    {
        dbDeneme dB = new dbDeneme();
        public int planEkle(DateTime _tarih, string _is)
        {
            return dB.AddNewPlan(new entitiesDeneme()
            {
                Tarih = _tarih,
                Jop = _is,
            });
        }

        public List<entitiesDeneme> planListe()
        {
            List<entitiesDeneme> planListesi = new List<entitiesDeneme>();
            try
            {
                SqlDataReader reader = dB.GetPlan();
                while (reader.Read()) //sqldatareaderdan gelen veriyi okur.
                {
                    planListesi.Add(new entitiesDeneme()
                    {
                        Tarih = reader.GetDateTime(0),
                        Jop = reader.GetString(1),
                    });
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return planListesi;
        }

    }
}
