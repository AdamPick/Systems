using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class Sensor
    {
        protected bool carOnSensor;

        public void CarDetected()
        {
            carOnSensor = true;
        }
        public void CarLeftSensor()
        {
            carOnSensor = false;
        }
        public bool IsCarOnSensor()
        {
            return carOnSensor;
        }
    }
}
