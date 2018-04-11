using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class ExitSensor: Sensor
    {
        private CarPark carPark;   
        
        public ExitSensor(CarPark carPark) 
        {
            this.carPark = carPark;
        }     
        public override bool CarDetected()          //overrides the abstract CarDetected bool already in sensor
        {
            carOnSensor = true;
            carPark.CarArrivedAtExit();           
            return carOnSensor;
        }    
        public override bool CarLeftSensor()        //overides the abstract CarLeftSensor bool already in sensor
        {
            carPark.CarExitedCarPark();
            carOnSensor = false;
            return carOnSensor;
        }

    }
}
