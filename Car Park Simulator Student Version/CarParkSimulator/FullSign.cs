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
            lit = false;
        }
        //operations
        public bool IsLit()
        {
            return lit;
        }
        public void SetLit(bool lit)
        {
            this.lit = lit;
        }
    }
}
