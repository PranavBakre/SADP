using System;
using creational.Car;
namespace creational
{
    class Program
    {

        static void Main(string[] args)
        {
            CarDealership dealership = new();
            var bedecar = dealership.CustomizeAndCreateCar(CarType.HatchBack, "red");
            Console.WriteLine(bedecar);
        }
    }
}
