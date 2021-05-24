using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            RoundHole roundHole = new RoundHole(15);
            RoundPeg roundPeg = new RoundPeg(23);
            Console.WriteLine(roundHole.Fits(roundPeg));

            AdapterSquarePeg adapterSquarePeg = new AdapterSquarePeg(10); // квадратный подшибник
            Console.WriteLine(roundHole.Fits(adapterSquarePeg));



            Console.ReadKey();
        }
    }
}
