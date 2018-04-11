using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class FullSign
    {
        //attributes
        private bool lit = false;
        //constructor
        public FullSign()
        {

        }
        //operations
        public bool IsLit()
        {
            return lit;
        }
        public bool SetLit()
        {
            lit = true;
            return lit;
        }
    }
}
