using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuri
{
    public class Pravougulnik
    {
        public double a;
        public double b;

        public void Perimeter()
        {
            Console.WriteLine((a + b) * 2);
        }

        public void Lice()
        {
            Console.WriteLine(a*b);
        }
    }
}

