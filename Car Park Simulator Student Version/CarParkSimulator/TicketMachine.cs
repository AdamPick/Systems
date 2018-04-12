using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{

    class TicketMachine
    {
        private CarPark carpark;

        private ActiveTickets activeTickets;
        private string message = "";

        public TicketMachine(ActiveTickets activeTickets)

        {
            this.activeTickets = activeTickets;
        }

        public void AssignCarPark(CarPark carpark)
        {
            this.carpark = carpark;
        }

        public void CarArrived()
        {
            message = "Press to get your ticket.";
        }

        public void PrintTicket()
        {
            activeTickets.AddTicket();
            message = "Thank you. Enjoy your stay";
        }

        public void ClearMessage()
        {
            message = "";

        }

        public string GetMessage()
        {
            return message;
        }
    }
}

