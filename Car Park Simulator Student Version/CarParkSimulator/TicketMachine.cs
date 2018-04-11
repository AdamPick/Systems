using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{


    class TicketMachine
    {

        private ActiveTickets activeTickets;
        private string message = " ";

        public TicketMachine(ActiveTickets activeTickets)

        {
            this.activeTickets = activeTickets;
        }

        public void AssignCarPark(CarPark carpark)
        {

        }

        public string CarArrived()
        {
            message = "Press to get your ticket.";
            return message;
        }

        public string PrintTicket()
        {

            message = "Thank you. Enjoy your stay";
            return message;
        }

        public string ClearMessage()
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

