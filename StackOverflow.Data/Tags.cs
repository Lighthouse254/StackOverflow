using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow.Data
{
    public class Tags
    {
        private string _IDTags;
        private string _NameTag;
        private string _Description;

        public string IDTags { get { return _IDTags; } set { _IDTags = value; } }
        public string NameTag { get { return _NameTag; } set { _NameTag = value; } }
        public string Description { get { return _Description; } set { _Description = value; } }

        public Data.Tags TagsIDataReader(SqlDataReader dr)
        {
            Data.Tags obj = new Data.Tags();
            obj.IDTags = dr["IDTags"] is DBNull ? string.Empty : dr["IDTags"].ToString();
            obj.NameTag = dr["NameTag"] is DBNull ? string.Empty : dr["NameTag"].ToString();
            obj.Description = dr["Description"] is DBNull ? string.Empty : dr["Description"].ToString();
            return obj;
        }
    }
}
