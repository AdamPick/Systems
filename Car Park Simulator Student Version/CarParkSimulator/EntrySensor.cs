using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class EntrySensor: sensor
    {
        private CarPark carPark;
        public EntrySensor(CarPark carPark) 
        {
            this.carPark = carPark;
        }     
        public bool CarDetected()
        {
            carOnSensor = true;
            carPark.CarArrivedAtEntrance();           
            return carOnSensor;
        }    
        public bool CarLeftSensor()
        {
            carPark.carEnteredCarPark();
            carOnSensor = false;
            return carOnSensor;
        }

    }
}
