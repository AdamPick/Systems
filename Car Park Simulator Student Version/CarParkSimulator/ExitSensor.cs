using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class ExitSensor: sensor
    {
        private CarPark carPark;                
        public Exit(CarPark carPark) 
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
            carPark.carExitedCarPark();
            carOnSensor = false;
            return carOnSensor;
        }

    }
}
