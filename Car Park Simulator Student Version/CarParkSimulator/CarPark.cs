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
        private TicketValidator tickeValidator;
    }
    
    public CarPark(FullSign fullSign, Barrier entryBarrier, Barrier exitBarrier, TicketMachine ticketMachine, TicketValidator ticketValidator){
        this.fullSign = fullSign;
        this.entryBarrier = entryBarrier;
        this.exitBarrier = exitBarrier;
        this.ticketMachine = ticketMachine;
        this.ticketValidator = ticketValidator;
    }
    
    
        
        public void CarArrivedAtEntrance()
        {
           return ticketMachine.CarArrived();
        }
    
        public string TicketDispensed()
        {
            entryBarrier.Raise();
            return ticketMachine.printTicket();
        }
        
        public int CarEnteredCarPark()
        {
            ticketMachine.ClearMessage();
            entryBarrier.Lower();  
            currentSpaces = currentSpaces - 1;
            if (currentSpaces > 0)
            {
                fullSign.lit = false;
            }
            else
            {
                fullSign.lit = true;
            }
            return currentSpaces;
        }
    
        public string CarArrivedAtExit()
        {
            return ticketValidator.CarArrived;
            
         }
    
        public string TicketValidated()
        {   
            exitBarrier.Raise();
            return ticketValidator.TicketEntered();
            
        }
        
        public int CarExitedCarPark()
        {
            ticketValidator.ClearMessage();
            exitBarrier.Lower();
            currentSpaces = currentSpaces + 1;
            if (currentSpaces > 0) {
                fullSign.lit = false;
            }
            return currentSpaces;
        }
    
        public bool isFull()
        {
            if(currentSpaces == 0){
                return true;
                }
                else
                    return false;
            }
        }
        
        public bool isEmpty()
        {               
            if(currentSpaces == 5){
                return true;
            }
            else{
                return false;
            }
        }
    
        public bool hasSpaces(){
            if(currentSpaces > 0){
                return true;
            }
                else
                    return false;
            }
            
         public int getCurrentSpaces(){
             return currentSpaces;
     }
