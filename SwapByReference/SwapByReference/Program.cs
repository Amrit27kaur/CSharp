using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapByReference
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 30;
            int b = 50;
           
            // int temp;
            Swap(ref a,ref b);
            Console.WriteLine("Swapping a{0} nad {1}",a,b);
            Console.ReadKey();

        }
        static void Swap(ref int x, ref int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
        }
    }
}
