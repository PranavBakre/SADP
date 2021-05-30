namespace creational.Car
{
    public class CarFactory
    {
        public static ICar Create(CarType type) => type switch
        {
            CarType.HatchBack => new HatchBack(),
            CarType.Truck => new Truck(),
            CarType.Sedan => new Sedan(),
            CarType.SUV => new SUV(),
            _ => null
        };
    }
}