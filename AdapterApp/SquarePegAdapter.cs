using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterComposition
{
    
    //  Пример на языке C# (Композиция)   https://ru.wikipedia.org/wiki/%D0%90%D0%B4%D0%B0%D0%BF%D1%82%D0%B5%D1%80_(%D1%88%D0%B0%D0%B1%D0%BB%D0%BE%D0%BD_%D0%BF%D1%80%D0%BE%D0%B5%D0%BA%D1%82%D0%B8%D1%80%D0%BE%D0%B2%D0%B0%D0%BD%D0%B8%D1%8F)#C#_-_%D0%BA%D0%BE%D0%BC%D0%BF%D0%BE%D0%B7%D0%B8%D1%86%D0%B8%D1%8F
    class SquarePegAdapter : RoundPeg // RoundPeg - круглый подшибник, SquarePegAdapter - адаптер квадратного подшибника
    {
        private SquarePeg peg; //поле SquarePeg - квадратный подшибник,
                               //композиция - когда обЪект одного класса находится внутри объекта другого класса
                               //внутри адаптера (SquarePegAdapter) находится квадратный подшибник - SquarePeg peg,


        public SquarePegAdapter(SquarePeg peg) : base((int)(peg.Width / Math.Sqrt(2))) //peg.Width / Math.Sqrt(2) - эквивалент радиуса
        {
            this.peg = peg;
        }

        //public SquarePegAdapter(SquarePeg peg) : base(0)
        //{
        //    this.peg = peg;
        //}

        //public override int Radius => (int)(peg.Width / Math.Sqrt(2));


    }
}
