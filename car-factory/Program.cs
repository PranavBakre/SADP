using System;
using car_factory.Car;
using car_factory.Car.Cars;
using car_factory.Car.Type;
using car_factory.Factory;

namespace car_factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Factory.\nCreate a batch\n1.HatchBack\n2.Sedan\n3.SUV\n4.Truck\nEnter the Number\n\n\n");
            var typeString = Console.ReadLine();

            Console.WriteLine("Enter the batch size");
            int size = int.Parse(Console.ReadLine());
            CarType type = (CarType)(int.Parse(typeString)-1);
            var batch = CarFactory.CreateBatch(type,size);

            CarFactory.PrintBatchDetails(batch);
            CarFactory.PaintBatch(batch,"red");
            CarFactory.PrintBatchDetails(batch);
        }
    }
}
