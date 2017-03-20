using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow.Data
{
    public class SQLDataProvider
    {
        public static string strConStr = "Data Source=NGUYENHAIDANG\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
        public static SqlConnection connection;

        public SQLDataProvider()
        {
            if (connection == null) { connection = new SqlConnection(strConStr); }
            //if (connection.State != ConnectionState.Open) { connection.Open(); }
        }

        public static SqlConnection GetConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
                return connection;
            }
            else
                return connection;
        }

        private SqlCommand GetCommand(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, GetConnection());
            return cmd;
        }

        public DataTable GetData(string sql)
        {
            return GetData(GetCommand(sql));
        }

        public DataTable GetData(SqlCommand cmd)
        {
            try
            {
                if (cmd.Connection == null) { cmd.Connection = GetConnection(); }
                using (DataSet ds = new DataSet())
                {
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        da.SelectCommand = cmd;
                        da.Fill(ds);
                        return ds.Tables[0];
                    }
                }
            }
            finally
            {

            }
        }

        public void ExecuteNonQuery(string sql)
        {
            ExecuteNonQuery(GetCommand(sql));
        }

        public void ExecuteNonQuery(SqlCommand cmd)
        {
            try
            {
                if (cmd.Connection == null) { cmd.Connection = GetConnection(); }
                cmd.ExecuteNonQuery();
            }
            finally
            {

            }
        }

        public object ExecuteScalar(string sql)
        {
            return ExecuteScalar(GetCommand(sql));
        }

        public object ExecuteScalar(SqlCommand cmd)
        {
            try
            {
                if (cmd.Connection == null) { cmd.Connection = GetConnection(); }
                return cmd.ExecuteScalar();
            }
            finally
            {

            }
        }

        public string MaxId(string Table, string ColId)
        {
            string strReturn = "";
            try
            {
                strReturn = ExecuteScalar("SELECT max(" + ColId + ") as maxid FROM " + Table).ToString();
            }
            catch
            {
                strReturn = "0";
            }
            return strReturn;
        }
    }
}
