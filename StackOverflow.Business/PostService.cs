using StackOverflow.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow.Business
{
    public class PostService
    {
        private static PostDAL instance = new PostDAL();

        public static List<Data.Post> Post_GetByTop(string Top, string Where, string Order)
        {
            return instance.Post_GetByTop(Top, Where, Order);
        }

        public static bool Post_Insert(Post data)
        {
            return instance.Post_Insert(data);
        }

        public static bool Post_Update(Post data)
        {
            return instance.Post_Update(data);
        }

        public static bool Post_Delete(string IDPost)
        {
            return instance.Post_Delete(IDPost);
        }
    }
}
