using System;
using System.Collections.Generic;
using System.Text;

namespace GenericSwap
{
    class Swap<T>
    {
        public List<T> Values  { get; set; }

        public Swap(List<T> values)
        {
            this.Values = values;
        }

        public void SwapItems(List<T> names, int firstIndex, int secondindex)
        {
            T tempValue = names[firstIndex];
            names[firstIndex] = names[secondindex];
            names[secondindex] = tempValue;

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var value in this.Values)
            {
                sb.AppendLine($"{value.GetType()}: {value.ToString()}");
            }

            return sb.ToString();
        }

    }
}
