using car_factory.Car.Type;
using System.Collections.Generic;
using car_factory.Iterator;
using System;

namespace car_factory.Car
{
    class Batch
    {
        public CarType Type { get; init; }

        private int _count;
        public int Count => _count;

        public int Size { get; init; }

        private List<ICar> _cars = new List<ICar>();
        public ICollection<ICar> Cars => _cars.AsReadOnly();
        public void AddCar(CarType type)
        {
            if (_cars.Count < Size)
            {
                var car = CarCreator.Create(type);
                _cars.Add(car);
                _count = _cars.Count;
            }
            else throw new System.Exception("Batch Full");

        }

        public Iterator<ICar> GetIterator()
        {
            return new Iterator<ICar>(_cars);
        }


    }

}