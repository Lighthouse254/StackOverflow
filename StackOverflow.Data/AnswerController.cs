using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow.Data
{
    public class AnswerDAL :SQLDataProvider
    {
        public List<Answer> Answer_GetByTop(string Top, string Where, string Order)
        {
            List<Data.Answer> list = new List<Answer>();
            using (SqlCommand dbCmd = new SqlCommand("sp_Answer_GetByTop", GetConnection()))
            {
                Data.Answer obj = new Data.Answer();
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
                        list.Add(obj.AnswerIDataReader(dr));
                    }
                }
                dr.Close();
                obj = null;
            }
            return list;
        }

        public bool Answer_Insert(Answer data)
        {
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_Answer_Insert", GetConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@IDPost", data.IDPost));
                    dbCmd.Parameters.Add(new SqlParameter("@IDUser", data.IDUser));
                    dbCmd.Parameters.Add(new SqlParameter("@AnswerContent", data.AnswerContent));
                    dbCmd.Parameters.Add(new SqlParameter("@UrlImage", data.UrlImage));
                    dbCmd.Parameters.Add(new SqlParameter("@TimeUpdated", data.TimeUpdated));
                    dbCmd.Parameters.Add(new SqlParameter("@TimeAnswer", data.TimeAnswer));
                    dbCmd.Parameters.Add(new SqlParameter("@IsResolved", data.IsResolved));
                    dbCmd.Parameters.Add(new SqlParameter("@Votes", data.Votes));
                    dbCmd.ExecuteNonQuery();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Answer_Update(Answer data)
        {
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_Answer_Update", GetConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@IDAnswer", data.IDAnswer));
                    dbCmd.Parameters.Add(new SqlParameter("@IDPost", data.IDPost));
                    dbCmd.Parameters.Add(new SqlParameter("@IDUser", data.IDUser));
                    dbCmd.Parameters.Add(new SqlParameter("@AnswerContent", data.AnswerContent));
                    dbCmd.Parameters.Add(new SqlParameter("@UrlImage", data.UrlImage));
                    dbCmd.Parameters.Add(new SqlParameter("@TimeUpdated", data.TimeUpdated));
                    dbCmd.Parameters.Add(new SqlParameter("@TimeAnswer", data.TimeAnswer));
                    dbCmd.Parameters.Add(new SqlParameter("@IsResolved", data.IsResolved));
                    dbCmd.Parameters.Add(new SqlParameter("@Votes", data.Votes));
                    dbCmd.ExecuteNonQuery();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Answer_Delete(string IDAnswer)
        {
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_Answer_Delete", GetConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@IDAnswer", IDAnswer));
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
