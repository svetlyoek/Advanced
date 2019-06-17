﻿namespace ListyIterator
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    public class ListyIterator<T>
    {
        private List<T> list;

        private int index;
        public ListyIterator(List<T> list)
        {
            this.list = list;
            this.index = 0;
        }

        public ListyIterator()
        {
        }

        public bool Move()
        {
            if (this.index < this.list.Count - 1)
            {
                index++;
                return true;
            }
            return false;
        }

        public bool HasNext()
        {
            if (this.index < this.list.Count - 1)
            {
                return true;
            }

            return false;
        }

        public void Print()
        {
            if (this.list.Count == 0)
            {
               throw new Exception ("Invalid Operation!");
            }

            Console.WriteLine(this.list[index]);

        }

    }

}
