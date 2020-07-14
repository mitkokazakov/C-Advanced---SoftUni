using System;
using System.Collections.Generic;
using System.Text;

namespace TupleGeneric
{
    public class Tuple<F,S>
    {
        public F FirstItem { get; set; }

        public S SecondItem { get; set; }

        public Tuple(F firstItem, S secondItem)
        {
            this.FirstItem = firstItem;
            this.SecondItem = secondItem;
        }

        public override string ToString()
        {
            return $"{this.FirstItem} -> {this.SecondItem}";
        }
    }
}
