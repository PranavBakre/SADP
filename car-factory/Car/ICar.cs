using car_factory.Car.Type;
namespace car_factory.Car
{

    public interface ICar
    {
        string Color { get; set; }
        CarType Type { get; init; }

        string ToString();
    }
}