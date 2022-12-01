using System;
using System.Data;
using System.Data.SqlClient;
using takvimProjesi.DbManager;

namespace denemeTakvim
{
    public class dbDeneme
    {
        SqlCommand cmd;
        private string connStr = @"data source = .; initial catalog = takvimDeneme; userID = aalagoz; password=Aa634163;Integrated Security=true;";
        ConnectionManager connManager;
        public dbDeneme()
        {
            connManager = new ConnectionManager();
        }
        public int AddNewPlan(entitiesDeneme e)
        {
            int result;
            try
            {
                var conn = connManager.CreateConnection(connStr);
                //connManager.OpenConnection(conn); //sql bağlantısı açılır

                cmd = new SqlCommand(@"insert into tabloDeneme (Tarih, İş) VALUES (@Tarih, @Is)", conn);
                cmd.Parameters.Add("@Tarih", SqlDbType.DateTime).Value = e.Tarih;
                cmd.Parameters.Add("@Is", SqlDbType.NVarChar).Value = e.Jop;

                result = cmd.ExecuteNonQuery(); //hazırlanan insert sorgusu sqle gönderilir. gelen cevap return values değişkenine alınır.
                connManager.CloseConnection(conn);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public SqlDataReader GetPlan()
        {
            try
            {
                var conn = connManager.CreateConnection(connStr);
                //connManager.OpenConnection(conn);
                cmd = new SqlCommand("Select * from planDeneme", conn);
                connManager.CloseConnection(conn);
                return cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
