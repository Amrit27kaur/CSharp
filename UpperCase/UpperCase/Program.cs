using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpperCase
{
    class Program
    {
        static void Main(string[] args)
        {

            //char a;
            Console.WriteLine("Please enter a character:");
             char a=((char)Console.Read());

            if (char.IsDigit(a))
                Console.WriteLine("Char is number");
            else if (char.IsLower(a))
                Console.WriteLine("Char is lower case");
            else if(char.IsUpper(a))
                Console.WriteLine("Char is upper case");
            else
                Console.WriteLine("Char is not alpha numeric");

            Console.ReadKey();
        }
    }
}
