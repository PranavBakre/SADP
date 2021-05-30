namespace creational.Car
{
    public interface ICar
    {
        public string Color { get; set; }
        public CarType Type { get; init; }
    }
}