using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex c1 = new Complex(2,5);
            Complex c2 = new Complex(3, 2);
            Complex c3 = new Complex();

           c3 =  c1 + c2;

            Console.WriteLine("Complex number is the addition is {0} and {1}", c3.Real,c3.Imaginary);
            Console.ReadKey();
        }
    }
}
