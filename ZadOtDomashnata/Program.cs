using System;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using System.Threading.Channels;

namespace ZadOtDomashnata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<Person> group2 = new List<Person>();

            //string propt = "";
            //int i = 0;
            //while (propt == "yes")
            //{
            //    Person person1 = new Person();
            //    Console.Write($"dai ime na {i}: ");
            //    person1.Name = Console.ReadLine();
            //    Console.Write($"dai godini {i}: ");
            //    person1.Age = int.Parse(Console.ReadLine());
            //    group2.Add(person1);
            //    Console.Write("iskash li oshte edin chovek: ");
            //    propt = Console.ReadLine();
            //    i++;
            //}

            //foreach (Person item in group2)
            //{
            //    item.Intruduce();
            //}

            Semeistvo myFamily = new Semeistvo();
            myFamily.FamilyName = "Ilievi";
            Console.Write("kolko choveka e familiqta: ");
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Console.Write($"vavedi {i + 1} chovek: ");
                Person current = new Person();
                Console.Write($"vavedi ime na {i + 1} chovek: ");
                current.Name = Console.ReadLine();
                Console.Write($"vavedi godini na {i + 1} chovek: ");
                current.Age = int.Parse(Console.ReadLine());
                myFamily.Members.Add(current);
            }

            //bubble sort
            for (int i = 0;i < count;i++)
            {
                for (int j = 0;j < count-1;j++)
                {
                    if (myFamily.Members[j].Age > myFamily.Members[j+1].Age)
                    {
                        Person temp = myFamily.Members[j];
                        myFamily.Members[j]= myFamily.Members[j+1];
                        myFamily.Members[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine();

            //Pechat
            myFamily.PrintAll();
        }
    }
}