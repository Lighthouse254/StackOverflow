using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow.Data
{
    public class PostDAL : SQLDataProvider
    {
        public List<Post> Post_GetByTop(string Top, string Where, string Order)
        {
            List<Data.Post> list = new List<Post>();
            using (SqlCommand dbCmd = new SqlCommand("sp_Post_GetByTop", GetConnection()))
            {
                Data.Post obj = new Data.Post();
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
                        list.Add(obj.PostIDataReader(dr));
                    }
                }
                dr.Close();
                obj = null;
            }
            return list;
        }

        public bool Post_Insert(Post data)
        {
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_Post_Insert", GetConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@IDUser", data.IDUser));
                    dbCmd.Parameters.Add(new SqlParameter("@Title", data.Title));
                    dbCmd.Parameters.Add(new SqlParameter("@PostContent", data.PostContent));
                    dbCmd.Parameters.Add(new SqlParameter("@CountViews", data.CountViews));
                    dbCmd.Parameters.Add(new SqlParameter("@TimeUpdated", data.TimeUpdated));
                    dbCmd.Parameters.Add(new SqlParameter("@TimeAsked", data.TimeAsked));
                    dbCmd.Parameters.Add(new SqlParameter("@IsResolved", data.IsResolved));
                    dbCmd.ExecuteNonQuery();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Post_Update(Post data)
        {
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_Post_Update", GetConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@IDPost", data.IDPost));
                    dbCmd.Parameters.Add(new SqlParameter("@IDUser", data.IDUser));
                    dbCmd.Parameters.Add(new SqlParameter("@Title", data.Title));
                    dbCmd.Parameters.Add(new SqlParameter("@PostContent", data.PostContent));
                    dbCmd.Parameters.Add(new SqlParameter("@CountViews", data.CountViews));
                    dbCmd.Parameters.Add(new SqlParameter("@TimeUpdated", data.TimeUpdated));
                    dbCmd.Parameters.Add(new SqlParameter("@TimeAsked", data.TimeAsked));
                    dbCmd.Parameters.Add(new SqlParameter("@IsResolved", data.IsResolved));
                    dbCmd.ExecuteNonQuery();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Post_Delete(string IDPost)
        {
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_Post_Delete", GetConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@IDPost", IDPost));
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
