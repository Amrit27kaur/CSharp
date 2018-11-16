using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultValues
{
    class Program
    {
        static void Main(string[] args)
        {
            perform("Hello", 30);
            perform("Hello");


            //named parameters
            perform(x: 40, a:"welcome");
            Console.ReadKey();
        }

        static void perform(string a , int x=21)//default parameters
        {
            Console.WriteLine("the value of a is {0}", a);
            Console.WriteLine("the value of a is {0}", x);
        }
    }
}
