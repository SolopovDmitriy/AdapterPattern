using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterComposition
{
    class RoundPeg
    {
        private int radius;

        public RoundPeg(int radius)
        {
            this.radius = radius;
        }

        public virtual int Radius => radius; // getter, равносилен коду снизу

        //public int Radius
        //{
        //    get
        //    {
        //        return radius;
        //    }
        //}




    }
}
