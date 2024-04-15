using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuri
{
    public class Triangle
    {
        public double a;
        public double b;
        public double c;

        public void Perimeter()
        {
            Console.WriteLine(a+b+c);
        }

        public void Lice()
        {
            double semiPerimeter = (a + b + c) / 2;
            Console.WriteLine(Math.Sqrt(semiPerimeter*(semiPerimeter-a)+ (semiPerimeter - b)+(semiPerimeter - c)));
        }
    }
}
