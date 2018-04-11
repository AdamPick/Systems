using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class CarPark
    {
        private int currentSpaces = 5;
        private const int maxSpace = 5;
        private FullSign fullSign;
        private Barrier entryBarrier;
        private Barrier exitBarrier;
        private TicketMachine ticketMachine;
        private TicketValidator ticketValidator;



        public CarPark(FullSign fullSign, Barrier entryBarrier, Barrier exitBarrier, TicketMachine ticketMachine, TicketValidator ticketValidator)
        {
            this.fullSign = fullSign;
            this.entryBarrier = entryBarrier;
            this.exitBarrier = exitBarrier;
            this.ticketMachine = ticketMachine;
            this.ticketValidator = ticketValidator;
        }



        public void CarArrivedAtEntrance()
        {
            ticketMachine.CarArrived();
        }

        public string TicketDispensed()
        {
            entryBarrier.Raise();
            return ticketMachine.GetMessage();
        }

        public int CarEnteredCarPark()
        {
            ticketMachine.ClearMessage();
            entryBarrier.Lower();
            currentSpaces = currentSpaces - 1;
            if (currentSpaces > 0)
            {
                fullSign.SetLit();
            }
            else
            {
                fullSign.SetLit();
            }
            return currentSpaces;
        }

        public void CarArrivedAtExit()
        {
            ticketValidator.CarArrived();

        }

        public string TicketValidated()
        {
            exitBarrier.Raise();
            return ticketValidator.GetMessage();

        }

        public int CarExitedCarPark()
        {
            ticketValidator.ClearMessage();
            exitBarrier.Lower();
            currentSpaces = currentSpaces + 1;
            if (currentSpaces > 0)
            {
                fullSign.SetLit();
            }
            return currentSpaces;
        }

        public bool IsFull()
        {
            if (currentSpaces == 0)
            {
                return true;
            }
            else
                return false;
        }
        public bool IsEmpty()
        {
            if (currentSpaces == 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool HasSpaces()
        {
            if (currentSpaces > 0)
            {
                return true;
            }
            else
                return false;
        }

        public int GetCurrentSpaces()
        {
            return currentSpaces;
        }
    }
}