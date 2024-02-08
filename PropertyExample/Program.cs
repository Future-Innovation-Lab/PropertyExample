namespace PropertyExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Car fastCar = new Car("Indica", "Tata", 110);
            fastCar.CurrentSpeed = 150;

            Console.WriteLine(fastCar.Model);
            Console.WriteLine(fastCar.CurrentSpeed);
        }
    }
}
