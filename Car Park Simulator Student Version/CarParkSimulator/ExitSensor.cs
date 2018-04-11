using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class ExitSensor: sensor
    {
        private CarPark carPark;
        public ExitSensor(CarPark carPark) 
        {
            this.carPark = carPark;
        }     
        public bool CarDetected()
        {
            carOnSensor = true;
            carPark.CarArrivedAtExit();           
            return carOnSensor;
        }    
        public bool CarLeftSensor()
        {
            carPark.carExitedCarPark();
            carOnSensor = false;
            return carOnSensor;
        }

    }
}
