using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class TicketValidator
      {
        private ActiveTickets activeTickets;
        private string message = " ";
        public TicketValidator(ActiveTickets activeTickets)
        {
         this.activeTickets = activeTickets;   
        } 
       
       
        
       public void AssignCarPark(CarPark carPark)
       {
           
       }
    
       public void CarArrived()
       {
           message = "Press to get your ticket.";
       }
    
        public void TicketEntered()
        {
            message= "Thank you, drive safely.";
        }
    
        public void ClearMessage(){
            message = "";
        }
    
        public string GetMessage(){
            
            return message;
        }
}
}
            
    
    
    
    
