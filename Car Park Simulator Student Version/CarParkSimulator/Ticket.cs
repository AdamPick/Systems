﻿using System;
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
            paid = false;
        }

        public bool IsPaid()
        {
            return paid;
        }

        public bool SetPaid()
        {
            paid = true;
            return paid;
        }
    }
}
