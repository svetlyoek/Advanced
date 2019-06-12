﻿
namespace GenericArrayCreator
{
    using System;
    using System.Collections.Generic;
    using System.Text; 

    public  class ArrayCreator
    {
        public static T[] Create<T>(int length, T item)
        {
            T[]data = new T[length];

            for(int i=0;i<length;i++)
            {
                data[i] = item;
            }
            return data;
        }
    }
}
