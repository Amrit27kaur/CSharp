using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            person p = new person();
            p.FirstName = "Amrit";
            p.LastName = "Kaur";
         

            Console.WriteLine("the name is {0} {1}", p.FirstName, p.LastName);
            Console.WriteLine("the fullname is {0} {1}", p.FirstName, p.LastName);
            Console.ReadKey();
        }
    }
}
