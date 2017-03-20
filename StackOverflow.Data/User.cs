using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow.Data
{
    public class User
    {
        private string _IDUser;
        private string _Username;
        private string _Password;
        private string _DisplayName;
        private string _Gender;
        private string _Email;
        private string _Avatar;
        private string _AboutMe;
        private string _Career;
        private string _Birthday;

        public string IDUser { get { return _IDUser; } set { _IDUser = value; } }
        public string Username { get { return _Username; } set { _Username = value; } }
        public string Password { get { return _Password; } set { _Password = value; } }
        public string DisplayName { get { return _DisplayName; } set { _DisplayName = value; } }
        public string Gender { get { return _Gender; } set { _Gender = value; } }
        public string Email { get { return _Email; } set { _Email = value; } }
        public string Avatar { get { return _Avatar; } set { _Avatar = value; } }
        public string AboutMe { get { return _AboutMe; } set { _AboutMe = value; } }
        public string Career { get { return _Career; } set { _Career = value; } }
        public string Birthday { get { return _Birthday; } set { _Birthday = value; } }

        public Data.User UserIDataReader(SqlDataReader dr)
        {
            Data.User obj = new Data.User();
            obj.IDUser = dr["IDUser"] is DBNull ? string.Empty : dr["IDUser"].ToString();
            obj.Username = dr["Username"] is DBNull ? string.Empty : dr["Username"].ToString();
            obj.Password = dr["Password"] is DBNull ? string.Empty : dr["Password"].ToString();
            obj.DisplayName = dr["DisplayName"] is DBNull ? string.Empty : dr["DisplayName"].ToString();
            obj.Gender = dr["Gender"] is DBNull ? string.Empty : dr["Gender"].ToString();
            obj.Email = dr["Email"] is DBNull ? string.Empty : dr["Email"].ToString();
            obj.Avatar = dr["Avatar"] is DBNull ? string.Empty : dr["Avatar"].ToString();
            obj.AboutMe = dr["AboutMe"] is DBNull ? string.Empty : dr["AboutMe"].ToString();
            obj.Career = dr["Career"] is DBNull ? string.Empty : dr["Career"].ToString();
            obj.Birthday = dr["Birthday"] is DBNull ? string.Empty : dr["Birthday"].ToString();
            return obj;
        }
    }
}
