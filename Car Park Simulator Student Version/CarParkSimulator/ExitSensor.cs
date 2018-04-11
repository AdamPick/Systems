using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class ExitSensor: Sensor
    {
        CarPark carPark;

        public ExitSensor(CarPark carPark)
        {
            this.carPark = carPark;
        }
    }
}
