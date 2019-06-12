
namespace GenericBoxOfString
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Box<T>
    {
        private T value;

        public Box(T value)
        {
            this.Value = value;
        }

        public T Value
        {
            get { return this.value; }

            set { this.value = value; }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append($"{this.Value.GetType()}: { this.Value}");

            return result.ToString();
        }

    }
}
