using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{       
    abstract class sensor                           //abstract because EntrySensor and ExitSensor are inheriting it and override it's methods
    {
        protected bool carOnSensor;                 //protected bool because carOnSensor can only be accessed by classes dervied from sensor

        public abstract bool CarDetected()          //abstract because EntrySensor and ExitSensor inherit it  
        {
            carOnSensor = true;
        }
        
        public abstract bool CarLeftSensor()       //abstract because EntrySensor and ExitSensor inherit it
        {
            carOnSensor = false;
        }
        
        public bool IsCarOnSensor() 
        {
            return carOnSensor;
        }
    }
}
