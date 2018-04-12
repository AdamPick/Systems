using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class PayStation
    {
        private Ticket;
        private ActiveTicket;
        private string message = "";
        private bool paid = true;

        public GetTicket(ActiveTicket)
        {
            this.ticket = new Ticket;
        }

        public string AddTicket()
        {
            message = "Please, insert your ticket";
        }

        public void Ticket()
        {
            paid = false;
        }

        public void PayTicket()
        {
            message = "Insert Cash";
            message = "Insert your payment method";
            payStation.IsPaid();
            exitBarrier.Raise();
        }

        public bool IsPaid()
        {
            return paid;
        }

        private void SetPaid()
        {
            ticket.SetPaid();
        }

        public string GetTicket(ActiveTickets)
        {
            message = " Thank you, Please collect your ticket. Have a good day!!!";
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
