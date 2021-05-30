using System;
using creational.Car;
namespace creational
{
    class Program
    {

        static void Main(string[] args)
        {
            CarDealership dealership = new();
            var car1 = dealership.CustomizeAndCreateCar(CarType.HatchBack, "red");
            Console.WriteLine(car1);
        }
    }
}
