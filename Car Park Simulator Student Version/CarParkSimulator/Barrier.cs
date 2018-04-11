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
            lifted = false;
        }

        //operations
        public bool Lower()
        {
            lifted = false;
            return lifted;
        }
        
        public bool Raise()
        {
            lifted = true;
            return lifted;
        }
        
        public bool IsLifted()
        {
            return lifted;
        }
    }
}
