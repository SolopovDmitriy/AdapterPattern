using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterInheritance
{
    public class SquarePeg
    {
        private int width;

        public SquarePeg(int width)
        {
            this.width = width;
        }

        public int Width => width; // getter Width
    }
}
