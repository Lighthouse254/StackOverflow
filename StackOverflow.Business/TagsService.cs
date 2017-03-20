using StackOverflow.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow.Business
{
    public class TagsService
    {
        private static TagsDAL instance = new TagsDAL();

        public static List<Data.Tags> Tags_GetByTop(string Top, string Where, string Order)
        {
            return instance.Tags_GetByTop(Top, Where, Order);
        }

        public static bool Tags_Insert(Tags data)
        {
            return instance.Tags_Insert(data);
        }

        public static bool Tags_Update(Tags data)
        {
            return instance.Tags_Update(data);
        }

        public static bool Tags_Delete(string IDTags)
        {
            return instance.Tags_Delete(IDTags);
        }
    }
}
