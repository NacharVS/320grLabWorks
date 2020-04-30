using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesInMiddleware
{
    public class MyMath
    {
        public int Sum(string mas)
        {
            char[] masChar = mas.ToCharArray();
            int sum = 0;

            foreach(char item in masChar)
            {
                sum += Convert.ToInt32(item.ToString());
            }

            return sum;
        }
        
        public int Multiplication(string mas)
        {
            char[] masChar = mas.ToCharArray();
            int sum = 1;

            foreach(char item in masChar)
            {
                sum *= Convert.ToInt32(item.ToString());
            }

            return sum;
        }
    }
}
