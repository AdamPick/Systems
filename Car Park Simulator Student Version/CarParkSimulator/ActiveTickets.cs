using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class ActiveTickets
    {
        private Ticket ticket;
        private List<Ticket> activeTickets;

        public ActiveTickets()
        {
            activeTickets = new List<Ticket>();
        }

        public int AddTicket()
        {
            ticket = new Ticket();
            activeTickets.Add(ticket);
            return ticket.GetHashCode();
        }

        public int RemoveTicket()
        {
            activeTickets.RemoveAt(0);
            return 0;
        }

        public int getTickets()
        {
            return activeTickets.First().GetHashCode();
        }
    }
}
