using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace takvimProjesi
{
    public class DatabaseLayer
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;
        public int  returnvalues;

        public DatabaseLayer()
        {
            con = new SqlConnection("data source = .; initial catalog = CalendarPlan; userID = aalagoz; password=Aa634163;Integrated Security=true;");

        }

        public void baglantiAyarla()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            else
            {
                con.Close();
            }
        }

        public int planEkle(plan p)
        {
            try
            {
                cmd = new SqlCommand("insert into planDeneme (ID, Plan1, Plan2, Plan3, Plan4, Plan5, Plan6, Plan7, Plan8, Plan9, Plan10)\r\nVALUES (@ID, @Plan1, @Plan2, @Plan3, @Plan4, @Plan5, @Plan6, @Plan7, @Plan8, @Plan9, @Plan10)", con);
                cmd.Parameters.Add("@ID", SqlDbType.UniqueIdentifier).Value = p.ID;
                cmd.Parameters.Add("@Plan1", SqlDbType.NVarChar).Value = p.Plan1;
                cmd.Parameters.Add("@Plan2", SqlDbType.NVarChar).Value = p.Plan2;
                cmd.Parameters.Add("@Plan3", SqlDbType.NVarChar).Value = p.Plan3;
                cmd.Parameters.Add("@Plan4", SqlDbType.NVarChar).Value = p.Plan4;
                cmd.Parameters.Add("@Plan5", SqlDbType.NVarChar).Value = p.Plan5;
                cmd.Parameters.Add("@Plan6", SqlDbType.NVarChar).Value = p.Plan6;
                cmd.Parameters.Add("@Plan7", SqlDbType.NVarChar).Value = p.Plan7;
                cmd.Parameters.Add("@Plan8", SqlDbType.NVarChar).Value = p.Plan8;
                cmd.Parameters.Add("@Plan9", SqlDbType.NVarChar).Value = p.Plan9;
                cmd.Parameters.Add("@Plan10", SqlDbType.NVarChar).Value = p.Plan10;

                baglantiAyarla(); //c# sql bağlantısı açılır
                returnvalues = cmd.ExecuteNonQuery(); //hazırlanan insert sorgusu sqle gönderilir. gelen cevap return values değişkenine alınır.


            }
            catch (Exception)
            {

            }
            finally
            {
                baglantiAyarla();
            }
            return returnvalues;
            
        }

        public SqlDataReader planListe()
        {
            cmd = new SqlCommand("Select * from planDeneme", con);
            baglantiAyarla();
            return cmd.ExecuteReader();
        }

        public SqlDataReader planListeID(Guid ID)
        {
            cmd = new SqlCommand("Select * from planDeneme where ID", con);
            cmd.Parameters.Add("@ID", SqlDbType.UniqueIdentifier).Value = ID;
            baglantiAyarla();
            return cmd.ExecuteReader();
        }

    }
}
