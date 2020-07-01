using System;
using System.Collections;
using System.Collections.Generic;

namespace Exer12._5
{
    public class ShortList<T> : IList<T>
    {
        private int maxsize = 10;
        private T[] items;
        private int count = 0;

        private readonly T[] emptyarray = new T[0];

        public ShortList() : this(10)
        {
            
        }
        public ShortList(int MaxSize)
        {
            if (MaxSize < 0) throw new ArgumentOutOfRangeException();

            maxsize = MaxSize;
            items = emptyarray;
        }
        public ShortList(IEnumerable<T> ts, int MaxSize = 10) : this()
        {
            if (MaxSize < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            maxsize = MaxSize;

            foreach (T item in ts)
            {
                Add(item);
            }
        }
        public T this[int index] { get => items[index]; set => items[index] = value; }

        public int Count => count;

        public bool IsReadOnly => false;

        public void Add(T item)
        {
            Resize();

            items[count++] = item;
        }

        protected void Resize()
        {
            if (Count == maxsize)
            {
                throw new IndexOutOfRangeException();
            }

            Array.Resize(ref items, Count + 1);
        }

        public void Clear()
        {
            items = emptyarray;
            count = 0;
        }

        public bool Contains(T item)
        {
            foreach (T listitem in this)
            {
                if (listitem.Equals(item))
                {
                    return true;
                }
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            int copyindex = arrayIndex;

            foreach (T item in this)
            {
                array.SetValue(item, copyindex++);
            }
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < count; i++)
            {
                if (items[i].Equals(item))
                {
                    return i;
                }
            }

            return -1;
        }

        public void Insert(int index, T item)
        {
            if (index + 1 >= maxsize || index < 0 || index > count) throw new ArgumentOutOfRangeException();

            // Highest index in array + 1 == count, so if index equals that it means we can add it at the end of the array
            if (index >= count)
            {
                Add(item);
                return;
            }

            Resize();

            for (int i = count; i > index; i--)
            {
                items[i] = items[i - 1];
            }

            items[index] = item;
        }

        public bool Remove(T item)
        {
            int itemindex = IndexOf(item);

            if (itemindex >= 0)
            {
                RemoveAt(itemindex);

                return true;
            }

            return false;
        }

        public void RemoveAt(int index)
        {
            if ((index >= 0) && (index < Count))
            {
                for (int i = index; i < Count - 1; i++)
                {
                    items[i] = items[i + 1];
                }
                count--;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach(T item in items)
                yield return item;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
