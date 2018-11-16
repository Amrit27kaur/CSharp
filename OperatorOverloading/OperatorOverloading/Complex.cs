using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    class Complex
    {

        private int real;
        private int imaginary;

        //create property for private real
        public int Real
        {
            get { return real;  }
            set { real = value; }
        }

        public int Imaginary
        {
            get { return imaginary; }
            set { real = value; }
        }

       public Complex()
        {
            real = 0;
            imaginary = 0;
        }

        public Complex(int r,int i)
        {
            real = r;
            imaginary = i;
        }

        //overload + operator

        public static Complex operator +(Complex c1, Complex c2)
        {
            Complex c3 = new Complex();

            //real part will b added with real part of Complex number
           c3.real= c1.real + c2.real;

            c3.imaginary = c1.imaginary + c2.imaginary;

            return c3;
        }
    }
}
