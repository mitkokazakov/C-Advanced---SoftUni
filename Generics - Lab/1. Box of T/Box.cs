using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOfT
{
    public class Box<T>
    {
        public Box()
        {
            this.Data = new Stack<T>();
        }

        public Stack<T> Data { get; set; }

        public int Count
        {
            get
            {
                return this.Data.Count;
            }
        }

        public void Add(T item)
        {
            this.Data.Push(item);
        }

        public T Remove()
        {
            T removedElement = this.Data.Pop();
            return removedElement;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in this.Data)
            {
                sb.AppendLine(item.ToString());
            }
            return $"{sb.ToString()}";
        }
    }
}
