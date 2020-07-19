using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stack
{
    public class StackData<T> : IEnumerable<T>
    {
        public List<T> AllElements;

        public StackData()
        {
            this.AllElements = new List<T>();
        }

        public void Push(T[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                this.AllElements.Add(arr[i]);
            }
        }
        public void Pop()
        {
            if (this.AllElements.Count == 0)
            {
                throw new InvalidOperationException("No elements");
            }
            else
            {
                this.AllElements.RemoveAt(this.AllElements.Count-1);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            
                for (int i = this.AllElements.Count - 1; i >= 0; i--)
                {
                    yield return this.AllElements[i];
                }

                for (int i = this.AllElements.Count - 1; i >= 0; i--)
                {
                    yield return this.AllElements[i];
                }
            
            

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
