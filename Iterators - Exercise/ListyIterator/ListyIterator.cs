using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ListyIterator
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> listData;
        private int index;

        public ListyIterator(List<T> list)
        {
            this.listData = list;
            this.index = 0;
        }

        public bool Move()
        {
            if (index + 1 < this.listData.Count)
            {
                this.index++;
                return true;
            }

            return false;
        }

        public bool HasNext()
        {
            if (index < this.listData.Count - 1)
            {
                return true;
            }

            return false;
        }

        public void Print()
        {
            if (this.listData.Count == 0)
            {
                throw new InvalidOperationException("Invalid operation!");
            }
            else
            {
                Console.WriteLine(this.listData[this.index]);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var element in this.listData)
            {
                yield return element;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
