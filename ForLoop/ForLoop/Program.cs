using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  int i;
              for (i = 5; i >= 1; i--)
              {
                  for (int j = 1; j <= i; j++)
                  {
                      Console.Write("*");
                  }
                  Console.WriteLine();
              }
               */
            /* int i;
             for (i = 1; i <= 5; i++)

             {

                 for (int j = 1; j <=i; j++)
                 {
                      Console.Write("*");

                 }
                 Console.WriteLine();
             }*/

            /*  int i;
              for (i = 1; i <= 5; i++)

              {

                  for (int j = 1; j <= i; j++)
                  {
                      Console.Write("*");

                  }
                  Console.WriteLine();
              }
              for (i = 5; i >= 1; i--)
              {
                  for (int j = 1; j <= i; j++)
                  {
                      Console.Write("*");
                  }
                  Console.WriteLine();
              } */

            //for half diamond

            int i;
            for (i = 5; i >= 1; i--)
            {



                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" ");

                }

                for (int j = 5; j >= i; j--)
                {
                    Console.Write("* ");

                }
                Console.WriteLine();

            }


            //for other half of diamond
           for (i = 1; i <= 5; i++)
            {

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" ");

                }

                for (int j = 5; j >= i; j--)
                {
                    Console.Write("* ");

                }


              
               
                Console.WriteLine();

            }


            Console.ReadKey();
        }
    }
}
