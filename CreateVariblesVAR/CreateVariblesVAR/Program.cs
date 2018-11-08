using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateVariblesVAR
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 3;
            var s1 = "Welcome";
            var s2 = true;

            Console.WriteLine("int value {0} ,"+"  "+" {1},"+"  "+" {2}", i, s1, s2);
           


            //Min And Max
         Console.WriteLine("the maxmum value for datatype byte is {0}", byte.MaxValue);
            Console.WriteLine("the minimum value for datatype byte is {0}", byte.MinValue);
            Console.WriteLine("the maxmum value for datatype int is {0}", int.MaxValue);
            Console.WriteLine("the maxmum value for datatype int is {0}", int.MinValue);
          

            //EScape Sequence
            Console.WriteLine("\"Amrit Kaur\"\n 1, Beaconcrest Road \nBrampton \nL6yoy8  \b\b\b\b Phoneno");


            //converting byte into int     implicit type conversion
            byte b = 3;
            int a = b;

            Console.WriteLine("{0}", a);

            //float to int
            float f1 = 3.2f;
            int a1 = (int)f1;                         //(int)f1 is explicit conversion
            Console.WriteLine("{0}", a1);

            //String to int
            String s = "123";
            // int St = int.Parse(s);                         //(int)f1 is Incompatible conversion
            int St = Convert.ToInt16(s);
            Console.WriteLine("{0}", St);

            //store value of i into byte
            //print the varaible of byte

            int j = 1000;
            byte b1 = (byte)j;
            Console.WriteLine(z);


            try
            {
                var num = "12345";
                byte z = Convert.ToByte(num);
                Console.WriteLine(z);
            }
            catch(System.OverflowException e)
            {
                Console.WriteLine("eneter the correct value");
            }


            Console.ReadKey();


        }
    }
}
