using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow.Data
{
    public class PostDetailDAL : SQLDataProvider
    {
        public List<PostDetail> PostDetail_GetByTop(string Top, string Where, string Order)
        {
            List<Data.PostDetail> list = new List<PostDetail>();
            using (SqlCommand dbCmd = new SqlCommand("sp_PostDetail_GetByTop", GetConnection()))
            {
                Data.PostDetail obj = new Data.PostDetail();
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
                        list.Add(obj.PostDetailIDataReader(dr));
                    }
                }
                dr.Close();
                obj = null;
            }
            return list;
        }

        public bool PostDetail_Insert(PostDetail data)
        {
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_PostDetail_Insert", GetConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@IDPost", data.IDPost));
                    dbCmd.Parameters.Add(new SqlParameter("@UrlImage", data.UrlImage));
                    dbCmd.Parameters.Add(new SqlParameter("@UrlVideo", data.UrlVideo));
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

        public bool PostDetail_Update(PostDetail data)
        {
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_PostDetail_Update", GetConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@IDPostDetail", data.IDPostDetail));
                    dbCmd.Parameters.Add(new SqlParameter("@IDPost", data.IDPost));
                    dbCmd.Parameters.Add(new SqlParameter("@UrlImage", data.UrlImage));
                    dbCmd.Parameters.Add(new SqlParameter("@UrlVideo", data.UrlVideo));
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

        public bool PostDetail_Delete(string IDPostDetail)
        {
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_PostDetail_Delete", GetConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@IDPostDetail", IDPostDetail));
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
