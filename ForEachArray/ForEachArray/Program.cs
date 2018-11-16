using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachArray
{
    class Program
    {
        static void Main(string[] args)
        {

            int [] a = { 1, 2, 3, 4, 5 };
            int i = 0;

            foreach (int j in a)
            
                Console.WriteLine("x{0} = {1}", i++, j);

                //lenght of array
                Console.WriteLine("lenght{0}", a.Length);


                //demension of array
                Console.WriteLine("Rank of array {0}", a.Rank);

            //2D array
            string[,] names =
            {
                {"John","smith" },
                {"mary","soni" },
                {"geroge","bush" }
            };

            foreach (string s in names)

                Console.WriteLine("element of array {0}", s);

            Console.WriteLine("Rank of array {0}", names.Rank);

            Console.ReadKey();
        }
    }
}
