using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Froggy
{
    public class Lake : IEnumerable<int>
    {
        public List<int> Names { get; set; }

        public Lake(List<int> names)
        {
            this.Names = names;
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < this.Names.Count; i++)
            {
                if (i % 2 == 0)
                {
                    yield return this.Names[i];
                }
            }

            for (int i = this.Names.Count - 1; i >= 0; i--)
            {
                if (i % 2 != 0)
                {
                    yield return this.Names[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
