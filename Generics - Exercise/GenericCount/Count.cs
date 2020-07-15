using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCount
{
    public class Count<T> where T : IComparable
    {
        public List<T> Items { get; set; }

        public Count(List<T> items)
        {
            this.Items = items;
        }

        public int CountItems(List<T> values, T elementToCompare)
        {
            int count = 0;

            foreach (var value in values)
            {
                int status = value.CompareTo(elementToCompare);

                if (status == 1)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
