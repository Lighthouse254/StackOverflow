using StackOverflow.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow.Business
{
    public class UserService
    {
        private static UserDAL instance = new UserDAL();

        public static List<Data.User> User_GetByTop(string Top, string Where, string Order)
        {
            return instance.User_GetByTop(Top, Where, Order);
        }

        public static List<Data.User> User_CheckLogin(string Username, string Password)
        {
            return instance.User_GetByTop("", "Username = '" + Username + "' and Password = '" + Password + "'", "");
        }

        public static List<Data.User> User_CheckEmail(string Username, string Email)
        {
            return instance.User_GetByTop("", "Username = '" + Username + "' and Email = '" + Email + "'", "");
        }

        public static bool CheckMatchUsername(string Username)
        {
            return instance.CheckMatchUsername(Username);
        }

        public static bool CheckMatchEmail(string Email)
        {
            return instance.CheckMatchEmail(Email);
        }

        public static bool User_Insert(User data)
        {
            return instance.User_Insert(data);
        }

        public static bool User_SignUp(User data)
        {
            return instance.User_SignUp(data);
        }

        public static bool User_Update(User data)
        {
            return instance.User_Update(data);
        }

        public static bool User_ForgotPassword(User data)
        {
            return instance.User_ForgotPassword(data);
        }

        public static bool User_Delete(string IDUser)
        {
            return instance.User_Delete(IDUser);
        }
    }
}
