using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperUnit
{
    class Program
    {
        static void Main(string[] args)
        {

            double result;
            Console.WriteLine("enter the temp");
          int temp =int.Parse(Console.ReadLine());

            Console.WriteLine("enter the unit");
           string unit = Convert.ToString(Console.ReadLine());

            if (unit == "cel" || unit == "Cel")
            {

              result = ((temp * 1.8) + 32);
               Console.WriteLine("new temp fah {0}", result);

            }
            else
            {
                result = (temp - 32) / 1.8;
               Console.WriteLine("new temp cel {0}", result);
            }
           Console.WriteLine("new temp {0}", result);
            Console.ReadKey();
        }
    }
}
