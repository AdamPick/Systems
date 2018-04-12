using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class TicketValidator
      {
        private CarPark carpark;
        private ActiveTickets activeTickets;
        private string message = "";
        public TicketValidator(ActiveTickets activeTickets)
        {
         this.activeTickets = activeTickets;   
        } 
       
       
        
       public void AssignCarPark(CarPark carPark)
       {
            carpark = carPark;
       }
    
       public void CarArrived()
       {
           message = "Please insert your ticket.";
       }
    
        public void TicketEntered()
        {
            activeTickets.RemoveTicket();
            message = "Thank you, drive safely.";
        }
    
        public void ClearMessage(){
            message = "";
        }
    
        public string GetMessage(){
            
            return message;
        }
}
}
            
    
    
    
    
