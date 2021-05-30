using creational.Machine;
namespace creational.Car
{

    public class CarDealership
    {
        public ICar CustomizeAndCreateCar(CarType type, string paint)
        {
            var car = CarFactory.Create(type);
            var machine = PaintingMachine.Instance;
            machine.Paint(car, paint);
            return car;
        }
    }
}