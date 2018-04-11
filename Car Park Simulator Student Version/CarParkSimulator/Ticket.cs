using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class Ticket
    {
        private bool paid;

        public Ticket()
        {
            this.paid = false;
        }

        public bool IsPaid()
        {
            return this.paid
        }

        public void SetPaid()
        {
            this.paid = true;
        }
    }
}
