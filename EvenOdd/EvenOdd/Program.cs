using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());

           var result= (num % 2 == 0) ? "even" : "odd";
            Console.WriteLine(result);
            

          /*  if (num % 2==0)
            {
                Console.WriteLine("even number");

            }
            else
            {
                Console.WriteLine("odd number");
                
            }*/
            Console.ReadKey();
        }
    }
}
