using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    public class Dog
    {
        //harakteristika
        public string name;
        public string breed;
        public int age;
        public double weight;

        //behaviour
        public void CanBark() 
        {
            Console.WriteLine($"{this.name}  baf la");
        }

        public int GrowUp()
        {
            return ++age;//uvelichava i pechata novite godini
        }

    }
}
