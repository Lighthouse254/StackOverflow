using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow.Data
{
    public class UserDetail
    {
        private string _IDUserDetail;
        private string _IDUser;
        private string _AccountFacebook;
        private string _AccountGoogle;
        private string _AccountGithub;
        private string _IDTags;

        public string IDUserDetail { get { return _IDUserDetail; } set { _IDUserDetail = value; } }
        public string IDUser { get { return _IDUser; } set { _IDUser = value; } }
        public string AccountFacebook { get { return _AccountFacebook; } set { _AccountFacebook = value; } }
        public string AccountGoogle { get { return _AccountGoogle; } set { _AccountGoogle = value; } }
        public string AccountGithub { get { return _AccountGithub; } set { _AccountGithub = value; } }
        public string IDTags { get { return _IDTags; } set { _IDTags = value; } }

        public Data.UserDetail UserDetailIDataReader(SqlDataReader dr)
        {
            Data.UserDetail obj = new Data.UserDetail();
            obj.IDUserDetail = dr["IDUserDetail"] is DBNull ? string.Empty : dr["IDUserDetail"].ToString();
            obj.IDUser = dr["IDUser"] is DBNull ? string.Empty : dr["IDUser"].ToString();
            obj.AccountFacebook = dr["AccountFacebook"] is DBNull ? string.Empty : dr["AccountFacebook"].ToString();
            obj.AccountGoogle = dr["AccountGoogle"] is DBNull ? string.Empty : dr["AccountGoogle"].ToString();
            obj.AccountGithub = dr["AccountGithub"] is DBNull ? string.Empty : dr["AccountGithub"].ToString();
            obj.IDTags = dr["IDTags"] is DBNull ? string.Empty : dr["IDTags"].ToString();
            return obj;
        }
    }
}
