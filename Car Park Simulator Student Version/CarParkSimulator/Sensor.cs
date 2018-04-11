using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{       
    abstract class sensor
    {
        protected bool carOnSensor;
        
        public sensor() 
        {
            
        }
        public abstract bool CarDetected();    
        public abstract bool CarLeftSensor();
        
        public bool IsCarOnSensor() 
        {
            return carOnSensor;
        }
    }
}
