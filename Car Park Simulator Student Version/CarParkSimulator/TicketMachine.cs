using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class TicketMachine (activeTickets)
    {
        message = " ";
    }
    
            private string message;

        public void AssignCarPark(CarPark)
        {
            this.carPark = carPark;
        }

        public void carArrived()
        {
            message = "Press to get your ticket.";
            
        }

        public void printTicket()
        {
            carPark.TicketDispensed();
        }

        public void clearMessage()
        {
            message = " ";
        }

        public string getMessage()
        {
            return message;
        }
    }
}
