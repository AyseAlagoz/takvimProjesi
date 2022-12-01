using entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace dbLayer
{
    public class dataBase
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;
        public int returnvalues;

        public dataBase()
        {
            con = new SqlConnection("data source = CTUR001L0200\\SQLEXPRESS; initial catalog = takvimDeneme; Integrated Security=true;");
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

        public int planEkle(plans p)
        {
            try
            {
                cmd = new SqlCommand("insert into tabloDeneme (Tarih, Planlar)\r\nVALUES (@Tarih, @Planlar)", con);
                cmd.Parameters.Add("@Tarih", SqlDbType.DateTime).Value = p.Tarih;
                cmd.Parameters.Add("@Planlar", SqlDbType.NVarChar).Value = p.Planlar;

                baglantiAyarla();
                returnvalues = cmd.ExecuteNonQuery();
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
            cmd = new SqlCommand("Select * from tabloDeneme", con);
            baglantiAyarla();
            return cmd.ExecuteReader();
        }

        public SqlDataReader haftalikListe(planListInput input)
        {
            cmd = new SqlCommand("Select * from tabloDeneme where Tarih between @startdate AND @finishdate", con);
            cmd.Parameters.Add("@startdate", SqlDbType.DateTime).Value = input.startdate;
            cmd.Parameters.Add("@finishdate", SqlDbType.DateTime).Value = input.finishdate;
            baglantiAyarla();
            return cmd.ExecuteReader();
        }

        public SqlDataReader gunlukListe(DateTime tarih)
        {
            cmd = new SqlCommand("Select * from tabloDeneme where Tarih = @Tarih", con);
            cmd.Parameters.Add("@Tarih", SqlDbType.DateTime).Value = tarih;
            baglantiAyarla();
            return cmd.ExecuteReader();
        }

        public class planListInput
        {
            public DateTime startdate { get; set; }
            public DateTime finishdate { get; set; }
        }


    }


}
