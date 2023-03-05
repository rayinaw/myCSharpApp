using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appCV.Models
{
    public class QuestionModel
    {
        public Object ObjResult { get; set; }
        public string TxtQuestion { get; set; }
        public int Result { get; set;}

        public void TwoDigitCalculation()
        {
            Random rand = new Random();

            int num1 = rand.Next(10, 100);
            int num2 = rand.Next(10, 100);
            char op = '+';
            switch (rand.Next(0, 3))
            {
                case 0:
                    Result = num1 + num2;
                    break;
                case 1:
                    Result = num1 - num2;
                    op = '-';
                    break;
                case 2:
                    Result = num1 * num2;
                    op = '*';
                    break;
            }

            TxtQuestion = string.Format("{0} {1} {2}", num1, op, num2);
        }
    }
}
