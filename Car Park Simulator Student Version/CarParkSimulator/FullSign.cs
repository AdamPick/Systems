using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class FullSign
    {
        //attributes
        private bool lit;
        //constructor
        public FullSign()
        {
            this.lit = false;
        }
        //operations
        public bool IsLit()
        {
            if (lit == true)
                return true;
            else
                return false;
        }
        public void SetLit()
        {
            lit = true;
        }
    }
}
