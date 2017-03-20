using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow.Data
{
    public class UserDetailDAL : SQLDataProvider
    {
        public List<UserDetail> UserDetail_GetByTop(string Top, string Where, string Order)
        {
            List<Data.UserDetail> list = new List<Data.UserDetail>();
            using (SqlCommand dbCmd = new SqlCommand("sp_Tags_GetByTop", GetConnection()))
            {
                Data.UserDetail obj = new Data.UserDetail();
                dbCmd.CommandType = CommandType.StoredProcedure;
                dbCmd.Parameters.Add(new SqlParameter("@Top", Top));
                dbCmd.Parameters.Add(new SqlParameter("@Where", Where));
                dbCmd.Parameters.Add(new SqlParameter("@Order", Order));
                SqlDataReader dr = dbCmd.ExecuteReader();
                dr.Close();
                dr = dbCmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        list.Add(obj.UserDetailIDataReader(dr));
                    }
                }
                dr.Close();
                obj = null;
            }
            return list;
        }

        public bool UserDetail_Insert(UserDetail data)
        {
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_UserDetail_Insert", GetConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@IDUser", data.IDUser));
                    dbCmd.Parameters.Add(new SqlParameter("@AccountFacebook", data.AccountFacebook));
                    dbCmd.Parameters.Add(new SqlParameter("@AccountGoogle", data.AccountGoogle));
                    dbCmd.Parameters.Add(new SqlParameter("@AccountGithub", data.AccountGithub));
                    dbCmd.Parameters.Add(new SqlParameter("@IDTags", data.IDTags));
                    dbCmd.ExecuteNonQuery();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UserDetail_Update(UserDetail data)
        {
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_UserDetail_Update", GetConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@IDUserDetail", data.IDUserDetail));
                    dbCmd.Parameters.Add(new SqlParameter("@IDUser", data.IDUser));
                    dbCmd.Parameters.Add(new SqlParameter("@AccountFacebook", data.AccountFacebook));
                    dbCmd.Parameters.Add(new SqlParameter("@AccountGoogle", data.AccountGoogle));
                    dbCmd.Parameters.Add(new SqlParameter("@AccountGithub", data.AccountGithub));
                    dbCmd.Parameters.Add(new SqlParameter("@IDTags", data.IDTags));
                    dbCmd.ExecuteNonQuery();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UserDetail_Delete(string IDUserDetail)
        {
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_UserDetail_Delete", GetConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@IDUserDetail", IDUserDetail));
                    dbCmd.ExecuteNonQuery();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
