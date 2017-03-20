using StackOverflow.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow.Business
{
    public class UserDetailService
    {
        private static UserDetailDAL instance = new UserDetailDAL();

        public static List<Data.UserDetail> UserDetail_GetByTop(string Top, string Where, string Order)
        {
            return instance.UserDetail_GetByTop(Top, Where, Order);
        }

        public static bool UserDetail_Insert(UserDetail data)
        {
            return instance.UserDetail_Insert(data);
        }

        public static bool UserDetail_Update(UserDetail data)
        {
            return instance.UserDetail_Update(data);
        }

        public static bool UserDetail_Delete(string IDUserDetail)
        {
            return instance.UserDetail_Delete(IDUserDetail);
        }
    }
}
