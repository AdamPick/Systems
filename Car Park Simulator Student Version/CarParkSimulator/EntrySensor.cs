using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class EntrySensor: Sensor
    {
        CarPark carPark;
        
        public EntrySensor(CarPark carPark) 
        {
            this.carPark = carPark;
        }
        
        public override bool CarDetected()          //overrides the abstract CarDetected bool already in sensor
        {
            carOnSensor = true;
            carPark.CarArrivedAtEntrance();           
            return carOnSensor;
        }    
        public override bool CarLeftSensor()        //overides the abstract CarLeftSensor bool already in sensor
        {
            carPark.CarEnteredCarPark();
            carOnSensor = false;
            return carOnSensor;
        }

    }
}
