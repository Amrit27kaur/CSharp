using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerationInCSharp
{
    //public enum Days { Sun, Mon, Tues, Wed, Thrus, Fri, Sat };
    class Program
    {
        static void Main(string[] args)
        {
          //  int x = (int)Days.Fri;
        //    Console.WriteLine(x);


          //  int y = (int)Days.Sat;
           // Console.WriteLine(y);

            int count = 0;
            int Result = 0;
          int   firstNum = 10;
            count++;
            Result = count++ * --firstNum + 100;
            Console.WriteLine(Result);
            Console.ReadKey();
        }
    }
}
