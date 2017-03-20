using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow.Data
{
    public class TagsDAL :SQLDataProvider
    {
        public List<Tags> Tags_GetByTop(string Top, string Where, string Order)
        {
            List<Data.Tags> list = new List<Data.Tags>();
            using (SqlCommand dbCmd = new SqlCommand("sp_Tags_GetByTop", GetConnection()))
            {
                Data.Tags obj = new Data.Tags();
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
                        list.Add(obj.TagsIDataReader(dr));
                    }
                }
                dr.Close();
                obj = null;
            }
            return list;
        }

        public bool Tags_Insert(Tags data)
        {
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_Tags_Insert", GetConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@NameTag", data.NameTag));
                    dbCmd.Parameters.Add(new SqlParameter("@Description", data.Description));
                    dbCmd.ExecuteNonQuery();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Tags_Update(Tags data)
        {
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_Tags_Update", GetConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@IDTags", data.IDTags));
                    dbCmd.Parameters.Add(new SqlParameter("@NameTag", data.NameTag));
                    dbCmd.Parameters.Add(new SqlParameter("@Description", data.Description));
                    dbCmd.ExecuteNonQuery();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Tags_Delete(string IDTags)
        {
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_Tags_Delete", GetConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@IDTags", IDTags));
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
