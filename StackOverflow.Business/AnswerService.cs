using StackOverflow.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow.Business
{
    public class AnswerService
    {
        private static AnswerDAL instance = new AnswerDAL();

        public static List<Data.Answer> Answer_GetByTop(string Top, string Where, string Order)
        {
            return instance.Answer_GetByTop(Top, Where, Order);
        }

        public static bool Answer_Insert(Answer data)
        {
            return instance.Answer_Insert(data);
        }

        public static bool Answer_Update(Answer data)
        {
            return instance.Answer_Update(data);
        }

        public static bool Answer_Delete(string IDAnswer)
        {
            return instance.Answer_Delete(IDAnswer);
        }
    }
}
