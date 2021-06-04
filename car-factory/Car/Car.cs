using car_factory.Car.Type;
namespace car_factory.Car
{
    public class Car : ICar
    {
        private string _color = null;
        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                if (_color == null) _color = value;
                else throw new System.Exception("Color already set");
            }
        }
        public CarType Type { get; init; }

        public override string ToString()
        {
            return $"This is a {Type} of color {Color}";
        }
    }
}