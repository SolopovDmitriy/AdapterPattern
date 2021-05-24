using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterInheritance
{
    public class AdapterSquarePeg : SquarePeg, IRound
    {
        public AdapterSquarePeg(int width) : base(width)
        {
        }

        public int Radius => (int)(Width / Math.Sqrt(2));
    }
}
