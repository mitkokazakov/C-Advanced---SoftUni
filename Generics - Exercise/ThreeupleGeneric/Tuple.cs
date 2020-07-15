using System;
using System.Collections.Generic;
using System.Text;

namespace ThreeupleGeneric
{
    public class Tuple<F,S,T>
    {
        public F FirstParam { get; set; }

        public S SecondParam { get; set; }

        public T ThirdParam { get; set; }

        public Tuple(F first, S second, T third)
        {
            this.FirstParam = first;
            this.SecondParam = second;
            this.ThirdParam = third;
        }

        public override string ToString()
        {
            return $"{this.FirstParam} -> {this.SecondParam} -> {this.ThirdParam}";
        }
    }
}
