using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow.Data
{
    public class Post
    {
        private string _IDPost;
        private string _IDUser;
        private string _Title;
        private string _PostContent;
        private string _CountViews;
        private string _TimeUpdated;
        private string _TimeAsked;
        private string _IsResolved;

        public string IDPost { get { return _IDPost; } set { _IDPost = value; } }
        public string IDUser { get { return _IDUser; } set { _IDUser = value; } }
        public string Title { get { return _Title; } set { _Title = value; } }
        public string PostContent { get { return _PostContent; } set { _PostContent = value; } }
        public string CountViews { get { return _CountViews; } set { _CountViews = value; } }
        public string TimeUpdated { get { return _TimeUpdated; } set { _TimeUpdated = value; } }
        public string TimeAsked { get { return _TimeAsked; } set { _TimeAsked = value; } }
        public string IsResolved { get { return _IsResolved; } set { _IsResolved = value; } }

        public Data.Post PostIDataReader(SqlDataReader dr)
        {
            Data.Post obj = new Data.Post();
            obj.IDPost = dr["IDPost"] is DBNull ? string.Empty : dr["IDPost"].ToString();
            obj.IDUser = dr["IDUser"] is DBNull ? string.Empty : dr["IDUser"].ToString();
            obj.Title = dr["Title"] is DBNull ? string.Empty : dr["Title"].ToString();
            obj.PostContent = dr["PostContent"] is DBNull ? string.Empty : dr["PostContent"].ToString();
            obj.CountViews = dr["CountViews"] is DBNull ? string.Empty : dr["CountViews"].ToString();
            obj.TimeUpdated = dr["TimeUpdated"] is DBNull ? string.Empty : dr["TimeUpdated"].ToString();
            obj.TimeAsked = dr["TimeAsked"] is DBNull ? string.Empty : dr["TimeAsked"].ToString();
            obj.IsResolved = dr["IsResolved"] is DBNull ? string.Empty : dr["IsResolved"].ToString();
            return obj;
        }
    }
}
