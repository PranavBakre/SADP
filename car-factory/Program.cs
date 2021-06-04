using System;
using car_factory.Car;
using car_factory.Car.Cars;
namespace car_factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Batch batch = new Batch();
            var car = new Sedan();
            Console.WriteLine("Hello World!");
        }
    }
}
