namespace FirstClass
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("POmqr");
            Dog dog1= new Dog();
            Dog pomqr= new Dog();


            dog1.name = "DAra";
            dog1.breed = "Melez";
            dog1.age = 4;
            dog1.weight= 6.5;

            pomqr.name = "Gulubin";
            pomqr.breed = "ulichno";
            pomqr.age = 54;
            pomqr.weight = 16;

            dog1.CanBark();
            dog1.CanBark();

            pomqr.CanBark();

            Console.WriteLine("CHRD brat me " + pomqr.GrowUp());

        }
    }
}
