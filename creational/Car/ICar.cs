namespace creational.Car
{
    public interface ICar
    {
        string Color { get; set; }
        CarType Type { get; init; }

        string ToString();
    }
}