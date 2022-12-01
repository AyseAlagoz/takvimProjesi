using System;
using System.Data.SqlClient;
using System.Data;

namespace takvimProjesi.DbManager
{
    public class ConnectionManager
    {
        public SqlConnection CreateConnection(string connectionString)
        {
            //return new SqlConnection(connectionString);
            try
            {
                var conn = new SqlConnection(connectionString);
                conn.Open();
                return conn;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //public bool OpenConnection(SqlConnection conn)
        //{
        //    try
        //    {
        //        if (conn.State == ConnectionState.Open)
        //            conn.Close();
        //        conn.Open();
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        public void CloseConnection(SqlConnection conn)
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
