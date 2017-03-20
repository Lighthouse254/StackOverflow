using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow.Data
{
    public class UserDAL : SQLDataProvider
    {
        public List<User> User_GetByTop(string Top, string Where, string Order)
        {
            List<Data.User> list = new List<User>();
            using (SqlCommand dbCmd = new SqlCommand("sp_User_GetByTop", GetConnection()))
            {
                Data.User obj = new Data.User();
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
                        list.Add(obj.UserIDataReader(dr));
                    }
                }
                dr.Close();
                obj = null;
            }
            return list;
        }

        public bool CheckMatchUsername(string Username)
        {
            try
            {
                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from UserInfo where Username = '"+ Username +"'", GetConnection());
                adapter.Fill(data);
                if (data == null || data.Rows.Count == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool CheckMatchEmail(string Email)
        {
            try
            {
                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from UserInfo where Email = '" + Email + "'", GetConnection());
                adapter.Fill(data);
                if (data == null || data.Rows.Count == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool User_Insert(User data)
        {
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_User_Insert", GetConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@Username", data.Username));
                    dbCmd.Parameters.Add(new SqlParameter("@Password", data.Password));
                    dbCmd.Parameters.Add(new SqlParameter("@DisplayName", data.DisplayName));
                    dbCmd.Parameters.Add(new SqlParameter("@Gender", data.Gender));
                    dbCmd.Parameters.Add(new SqlParameter("@Email", data.Email));
                    dbCmd.Parameters.Add(new SqlParameter("@Avatar", data.Avatar));
                    dbCmd.Parameters.Add(new SqlParameter("@AboutMe", data.AboutMe));
                    dbCmd.Parameters.Add(new SqlParameter("@Career", data.Career));
                    dbCmd.Parameters.Add(new SqlParameter("@Birthday", data.Birthday));
                    dbCmd.ExecuteNonQuery();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool User_SignUp(User data)
        {
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_User_SignUp", GetConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@Username", data.Username));
                    dbCmd.Parameters.Add(new SqlParameter("@Password", data.Password));
                    dbCmd.Parameters.Add(new SqlParameter("@Email", data.Email));
                    dbCmd.ExecuteNonQuery();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool User_Update(User data)
        {
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_User_Update", GetConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@IDUser", data.IDUser));
                    //dbCmd.Parameters.Add(new SqlParameter("@Username", data.Username));
                    //dbCmd.Parameters.Add(new SqlParameter("@Password", data.Password));
                    dbCmd.Parameters.Add(new SqlParameter("@DisplayName", data.DisplayName));
                    dbCmd.Parameters.Add(new SqlParameter("@Gender", data.Gender));
                    dbCmd.Parameters.Add(new SqlParameter("@Email", data.Email));
                    dbCmd.Parameters.Add(new SqlParameter("@Avatar", data.Avatar));
                    dbCmd.Parameters.Add(new SqlParameter("@AboutMe", data.AboutMe));
                    dbCmd.Parameters.Add(new SqlParameter("@Career", data.Career));
                    dbCmd.Parameters.Add(new SqlParameter("@Birthday", data.Birthday));
                    dbCmd.ExecuteNonQuery();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool User_ForgotPassword(User data)
        {
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_User_ForgotPassword", GetConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@Username", data.Username));
                    dbCmd.Parameters.Add(new SqlParameter("@Password", data.Password));
                    dbCmd.ExecuteNonQuery();
                }
                return true;
            }
            catch
            {
                throw;
            }
        }

        public bool User_Delete(string IDUser)
        {
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_User_Delete", GetConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@IDUser", IDUser));
                    dbCmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
