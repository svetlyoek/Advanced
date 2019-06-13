
namespace GenericCountMethodString
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Box<T>
    {
        private List<T> data;

        private T item;
        public Box()
        {
            this.data = new List<T>();
            this.Item = item;
        }

        public List<T> Data
        {
            get { return this.data; }

            set { this.data = value; }
        }

        public T Item
        {
            get { return this.item; }

            set { this.item = value; }
        }

        public void Add(T item)
        {
            this.data.Add(item);
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in this.data)
            {
                sb.AppendLine($"{item.GetType()}: {item}");
            }

            return sb.ToString();
        }
    }
}
