using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallByReference
{
    class Program
    {
        static void Main(string[] args)



        {

            //callby value 
            int testeValue = 1;
            Console.WriteLine("Original value is {0}", testeValue);
            TestCallByValue( testeValue);
           
            Console.WriteLine("After calling TestCallByValue the value is {0}", testeValue);

           
            //reference
            Console.WriteLine("Original value is {0}", testeValue);
            TestRef(ref testeValue);
            Console.WriteLine("After calling TestRef the value is {0}", testeValue);

            //call by reference using out -keyword
            int tstValue = 120;
            Console.WriteLine("Original value is {0}", tstValue);
            TestOut(out tstValue);
            Console.WriteLine("After calling TestRef the value is {0}", tstValue);
            Console.ReadKey();
        }

        static void TestOut(out int aValue)
        {
            aValue = 500;
            Console.WriteLine("Inside TestOut the value is {0}", aValue);
        }


       static void TestCallByValue(int aValue)
        {
            aValue = 50;
            Console.WriteLine("Inside TestCallByeValue the value is {0}", aValue);
        }

        //refercene
        static void TestRef(ref int aValue)
        {
            aValue = 100;
            Console.WriteLine("Inside Testref the value is {0}", aValue);
        }

    }
}
