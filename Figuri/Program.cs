namespace Figuri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Square square=new Square();
            square.strana1 = double.Parse(Console.ReadLine());

            Console.WriteLine("perimeter");
            square.Perimeter();

            Console.WriteLine("lice");
            square.Lice();


            Triangle triangle = new Triangle();
            triangle.a=double.Parse(Console.ReadLine());
            triangle.b=double.Parse(Console.ReadLine());
            triangle.c=double.Parse(Console.ReadLine());

            Console.WriteLine("perimeter");
            triangle.Perimeter();

            Console.WriteLine("lice");
            triangle.Lice();

            Pravougulnik pravougulnik = new Pravougulnik();
            pravougulnik.a=double.Parse(Console.ReadLine());
            pravougulnik.b=double.Parse(Console.ReadLine());

            Console.WriteLine("perimeter");
            pravougulnik.Perimeter();

            Console.WriteLine("lice");
            pravougulnik.Lice();

        }
    }
}
