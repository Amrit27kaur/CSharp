using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddReference
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 30;
            int b = 50;
            int result;

            add(a, b, out result);
            Console.WriteLine("The addition is {0}", result);
            Console.ReadKey();
        }

        static void add(int x , int y , out int result)
        {
            result = x + y;
        }
    }
}
