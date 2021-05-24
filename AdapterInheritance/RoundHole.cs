using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterInheritance
{
    class RoundHole
    {
        private int radius;

        public RoundHole(int radius)
        {
            this.radius = radius;
        }
    
        public int Radius
        {
            get
            {
                return radius;
            }
        }

        public bool Fits(IRound peg)
        {
            return this.Radius >= peg.Radius;
        }
    
    }
}
