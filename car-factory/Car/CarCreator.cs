using car_factory.Car.Cars;
using car_factory.Car.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_factory.Car
{
    class CarCreator
    {
        public static ICar Create(CarType type) => type switch
        {
            CarType.HatchBack => new HatchBack(),
            CarType.Truck => new Truck(),
            CarType.Sedan => new Sedan(),
            CarType.SUV => new SUV(),
            _ => throw new Exception("Wrong input Selected. Cannot create car")
        };
    }
}
