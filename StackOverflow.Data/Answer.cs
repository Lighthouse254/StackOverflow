using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow.Data
{
    public class Answer
    {
        private string _IDAnswer;
        private string _IDPost;
        private string _IDUser;
        private string _AnswerContent;
        private string _UrlImage;
        private string _TimeUpdated;
        private string _TimeAnswer;
        private string _IsResolved;
        private string _Votes;

        public string IDAnswer { get { return _IDAnswer; } set { _IDAnswer = value; } }
        public string IDPost { get { return _IDPost; } set { _IDPost = value; } }
        public string IDUser { get { return _IDUser; } set { _IDUser = value; } }
        public string AnswerContent { get { return _AnswerContent; } set { _AnswerContent = value; } }
        public string UrlImage { get { return _UrlImage; } set { _UrlImage = value; } }
        public string TimeUpdated { get { return _TimeUpdated; } set { _TimeUpdated = value; } }
        public string TimeAnswer { get { return _TimeAnswer; } set { _TimeAnswer = value; } }
        public string IsResolved { get { return _IsResolved; } set { _IsResolved = value; } }
        public string Votes { get { return _Votes; } set { _Votes = value; } }

        public Data.Answer AnswerIDataReader(SqlDataReader dr)
        {
            Data.Answer obj = new Data.Answer();
            obj.IDAnswer = dr["IDAnswer"] is DBNull ? string.Empty : dr["IDAnswer"].ToString();
            obj.IDPost = dr["IDPost"] is DBNull ? string.Empty : dr["IDPost"].ToString();
            obj.IDUser = dr["IDUser"] is DBNull ? string.Empty : dr["IDUser"].ToString();
            obj.AnswerContent = dr["AnswerContent"] is DBNull ? string.Empty : dr["AnswerContent"].ToString();
            obj.UrlImage = dr["UrlImage"] is DBNull ? string.Empty : dr["UrlImage"].ToString();
            obj.TimeUpdated = dr["TimeUpdated"] is DBNull ? string.Empty : dr["TimeUpdated"].ToString();
            obj.TimeAnswer = dr["TimeAnswer"] is DBNull ? string.Empty : dr["TimeAnswer"].ToString();
            obj.IsResolved = dr["IsResolved"] is DBNull ? string.Empty : dr["IsResolved"].ToString();
            obj.Votes = dr["Votes"] is DBNull ? string.Empty : dr["Votes"].ToString();
            return obj;
        }
    }
}
