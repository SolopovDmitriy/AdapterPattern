using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterInheritance
{
    public class RoundPeg : IRound
    {
        private int radius;

        public RoundPeg(int radius)
        {
            this.radius = radius;
        }

        public virtual int Radius => radius;
    }
}
