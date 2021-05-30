using creational.Car;
namespace creational.Machine
{
    public class PaintingMachine
    {
        private static PaintingMachine _instance;
        public static PaintingMachine Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PaintingMachine();
                }

                return _instance;
            }

        }
        public void Paint(ICar car, string color)
        {
            car.Color = color;
        }
    }
}