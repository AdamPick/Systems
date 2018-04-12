using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParkSimulator
{
    class PayStation
    {
        private Ticket ticket;
        public PayStation()
        {
            this.ticket = new Ticket();
        }

        public int TicketPayment(ActiveTickets activeTickets)
        {
            ticket.SetPaid();
            return activeTickets.GetTickets();
        }
    }
}
