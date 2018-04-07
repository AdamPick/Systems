using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class TicketValidator
    {
        private string message;
       
        public TicketValidator(string message)
        {
            this.message = message;
        }
        
        
        public string GetMessage(){
            return message;
        }
        
        public bool CarArrived(){
        }
        
        
    }
}
