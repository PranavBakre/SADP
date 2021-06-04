using car_factory.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_factory.Machines
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
