using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageNo134
{
    class Program
    {
        static void Main(string[] args)
        {
         int marks1 = 76;
        double marks2 = 66.78;
          int marks3 = 56;
          int marks4 = 46;
           int marks5 = 36;
         const int total = 5;

            double result = 0;
            result = marks1 + marks2 + marks3 + marks4 + marks5/total;

            Console.WriteLine("{0:n2}",result);
            Console.ReadKey();
        }
    }
}
