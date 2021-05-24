using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterComposition
{
    class Program
    {
        static void Main(string[] args)
        {
            //RoundHole roundHole = new RoundHole(12);
            //Console.WriteLine(roundHole.Radius);
            //int x = roundHole.Radius; // read roundHole.Radius
            //// roundHole.Radius = 45; // write roundHole.Radius



            RoundHole hole = new RoundHole(5);// создаем отверствие радиусом 5
            RoundPeg rpeg = new RoundPeg(5);// создаем круглый подшибник, радиусом 5
            Console.WriteLine("hole.Fits(rpeg) = " + hole.Fits(rpeg)); // TRUE

            SquarePeg small_sqpeg = new SquarePeg(5); // создаю объект класса квадрат
            SquarePeg large_sqpeg = new SquarePeg(10);
            // hole.Fits(small_sqpeg); // Ошибка компиляции, несовместимые типы

            SquarePegAdapter small_sqpeg_adapter = new SquarePegAdapter(small_sqpeg);// создаю объект класса адаптер квадрата и
                                                                                     // передаю параметр small_sqpeg, который
                                                                                     // соответствует обЪекту peg  класса SquarePeg 
            SquarePegAdapter large_sqpeg_adapter = new SquarePegAdapter(large_sqpeg);
            Console.WriteLine(large_sqpeg_adapter.Radius);
            Console.WriteLine("large_sqpeg_adapter is RoundPeg = " + (large_sqpeg_adapter is RoundPeg));

            Console.WriteLine("hole.Fits(small_sqpeg_adapter) = " + hole.Fits(small_sqpeg_adapter)); // TRUE
            Console.WriteLine("hole.Fits(large_sqpeg_adapter) = " + hole.Fits(large_sqpeg_adapter)); // FALSE

            Console.ReadKey();
        }
    }
}
