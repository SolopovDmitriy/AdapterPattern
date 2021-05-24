using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterComposition
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

        public bool Fits(RoundPeg peg) // peg - переменная подшибник, RoundPeg peg - круглый подшибник
        {
            return this.Radius >= peg.Radius;
        }
    
    }
}
