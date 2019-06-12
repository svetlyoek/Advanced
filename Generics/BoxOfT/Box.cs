
namespace BoxOfT
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Box<T>
    {
        private List<T> elements;

        private T element;

      
        public Box()
        {
            this.Element = element;
            this.Elements = new List<T>();
        }
        public List<T> Elements
        {
            get { return this.elements; }
            set { this.elements = value; }
        }
        public T Element
        {
            get { return this.element; }
            set { this.element = value; }
        }

        public int Count => this.elements.Count;

        public void Add(T element)
        {
            this.elements.Add(element);
        }

        public T Remove()
        {
            if(this.elements.Count>0)
            {
                var removeElement = this.elements.Last();
                this.elements.RemoveAt(this.elements.Count-1);
                return removeElement;
            }

           throw new IndexOutOfRangeException("Can not remove element that doesn't exist");
        }
    }
}
