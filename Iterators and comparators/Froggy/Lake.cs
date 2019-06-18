namespace Froggy
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    public class Lake<T> : IEnumerable<int>
    {
        private List<int> stones;

        public Lake(List<int> stones)
        {
            this.Stones = new List<int>(stones);

        }

        public List<int> Stones
        {
            get { return this.stones; }
            set { this.stones = value; }
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < this.stones.Count; i++)
            {
                if (i % 2 == 0)
                {
                    yield return this.stones[i];
                }
            }

            for (int i = this.stones.Count - 1; i >= 0; i--)
            {
                if (i % 2 != 0)
                {
                    yield return this.stones[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
