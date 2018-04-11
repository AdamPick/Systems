using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{


    class TicketMachine
    {
       
        private string message = " ";
        
       public TicketMachine(ActiveTickets)
            
            {
            this.ActiveTickets = ActiveTickets;
            }               

        public void AssignCarPark(CarPark)
        {
            this.CarPark = CarPark;
        }

        public string CarArrived()
        {
            message = "Press to get your ticket.";
            return message;
        }
        
        public string PrintTicket()
            {
            CarPark.TicketDispensed();
            message = "Please collect your ticket. Thank you!";
            return message;
            }

        public void ClearMessage()
        {
            message = " ";
            return message;

        }

        public string GetMessage()
        {
            return message;
        }
    }
}
