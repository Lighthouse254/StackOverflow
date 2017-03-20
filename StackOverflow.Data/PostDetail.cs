using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow.Data
{
    public class PostDetail
    {
        private string _IDPostDetail;
        private string _IDPost;
        private string _UrlImage;
        private string _UrlVideo;
        private string _IDTags;

        public string IDPostDetail { get { return _IDPostDetail; } set { _IDPostDetail = value; } }
        public string IDPost { get { return _IDPost; } set { _IDPost = value; } }
        public string UrlImage { get { return _UrlImage; } set { _UrlImage = value; } }
        public string UrlVideo { get { return _UrlVideo; } set { _UrlVideo = value; } }
        public string IDTags { get { return _IDTags; } set { _IDTags = value; } }

        public Data.PostDetail PostDetailIDataReader(SqlDataReader dr)
        {
            Data.PostDetail obj = new Data.PostDetail();
            obj.IDPostDetail = dr["IDPostDetail"] is DBNull ? string.Empty : dr["IDPostDetail"].ToString();
            obj.IDPost = dr["IDPostl"] is DBNull ? string.Empty : dr["IDPost"].ToString();
            obj.UrlImage = dr["UrlImage"] is DBNull ? string.Empty : dr["UrlImage"].ToString();
            obj.UrlVideo = dr["UrlVideo"] is DBNull ? string.Empty : dr["UrlVideo"].ToString();
            obj.IDTags = dr["IDTags"] is DBNull ? string.Empty : dr["IDTags"].ToString();
            return obj;
        }
    }
}
