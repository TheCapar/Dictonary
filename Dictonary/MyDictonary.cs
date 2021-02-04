using System;
using System.Collections.Generic;
using System.Text;

namespace Dictonary
{
    class MyDictonary<T>
    {
        T[] items;
        public MyDictonary()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArrays = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArrays.Length; i++)
            {
                items[i] = tempArrays[i];
            }
            items[items.Length - 1] = item;
        }
        public int Lenght
        {
            get { return items.Length; }
        }
        public T[] Items
        {
            get { return items; }
        }

    }
}
