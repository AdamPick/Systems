using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class Barrier
    {
        //attributes
        private bool lifted;
        
        //constructor
        public Barrier()
        {
            this.lifted = false;
        }
        
        //operations
        public void Lower()
        {
            this.lifted = false;
        }
        
        public void Raise()
        {
            this.lifted = true;
        }
        
        public bool IsLifted()
        {
            return this.lifted
        }
    }
}
