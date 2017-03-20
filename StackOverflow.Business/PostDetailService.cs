using StackOverflow.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow.Business
{
    public class PostDetailService
    {
        private static PostDetailDAL instance = new PostDetailDAL();

        public static List<Data.PostDetail> PostDetail_GetByTop(string Top, string Where, string Order)
        {
            return instance.PostDetail_GetByTop(Top, Where, Order);
        }

        public static bool PostDetail_Insert(PostDetail data)
        {
            return instance.PostDetail_Insert(data);
        }

        public static bool PostDetail_Update(PostDetail data)
        {
            return instance.PostDetail_Update(data);
        }

        public static bool PostDetail_Delete(string IDPostDetail)
        {
            return instance.PostDetail_Delete(IDPostDetail);
        }
    }
}
