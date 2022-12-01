using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace takvimProjesi
{
    
    public class businessLayer
    {
        DatabaseLayer dL = new DatabaseLayer();
        public int planEkle(string plan1, string plan2, string plan3, string plan4,
            string plan5, string plan6, string plan7, string plan8, string plan9, string plan10)
        {
           return dL.planEkle(new plan()
            {
                ID = Guid.NewGuid(),
                Plan1 = plan1,
                Plan2 = plan2,
                Plan3 = plan3,
                Plan4 = plan4,
                Plan5 = plan5,
                Plan6 = plan6,
                Plan7 = plan7,
                Plan8 = plan8,
                Plan9 = plan9,
                Plan10 = plan10,
            });

            //DatabaseLayer abc = new DatabaseLayer();
            //plan pplan = new plan();

            //int b = abc.planEkle(pplan);
            //int a = new DatabaseLayer().planEkle(pplan);          
        }
       
        public List<plan> planListe()
        {
            List<plan> planListesi = new List<plan>();
            try
            {
                SqlDataReader reader = dL.planListe();
                while (reader.Read()) //sqldatareaderdan gelen veriyi okur.
                {
                    planListesi.Add(new plan()
                    {
                        ID =reader.GetGuid(0),
                        Plan1 = reader.GetString(1),
                        Plan2 = reader.GetString(2),
                        Plan3 = reader.GetString(3),
                        Plan4 = reader.GetString(4),
                        Plan5 = reader.GetString(5),
                        Plan6 = reader.GetString(6),
                        Plan7 = reader.GetString(7),
                        Plan8 = reader.GetString(8),
                        Plan9 = reader.GetString(9),
                        Plan10 = reader.GetString(10),

                    });
                }
                reader.Close();
            }
            catch (Exception)
            {

                
            }
            finally
            {
                dL.baglantiAyarla();
            }
            return planListesi;
        }

        public plan planListeID(Guid ID)
        {
            plan planKayıt = new plan();
            try
            {
                SqlDataReader reader = dL.planListeID(ID);
                while (reader.Read()) //sqldatareaderdan gelen veriyi okur.
                {
                    planKayıt = new plan()
                    {
                        ID = reader.GetGuid(0),
                        Plan1 = reader.GetString(1),
                        Plan2 = reader.GetString(2),
                        Plan3 = reader.GetString(3),
                        Plan4 = reader.GetString(4),
                        Plan5 = reader.GetString(5),
                        Plan6 = reader.GetString(6),
                        Plan7 = reader.GetString(7),
                        Plan8 = reader.GetString(8),
                        Plan9 = reader.GetString(9),
                        Plan10 = reader.GetString(10),

                    };
                }
                reader.Close();
            }
            catch (Exception)
            {


            }
            finally
            {
                dL.baglantiAyarla();
            }
            return planKayıt;
        }

    }


}
