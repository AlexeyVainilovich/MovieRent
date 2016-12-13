using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesRent
{
    public class Collection<T> : ICollection<T>
    {
        private T[] myArray = new T[0];
        private int _Count;

        public Collection()
        {
            _Count = 0;
        }

        public int Count
        {
            get
            {
                return _Count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public void Add(T item)
        {
            if (myArray.Length - _Count == 0)
            {
                Array.Resize(ref myArray, myArray.Length + 256);
            }

            _Count++;
            myArray[_Count] = item;
        }

        public void Clear()
        {
            if (_Count == 0)
            {
                return;
            }

            for (int i = 0; i < _Count; i++)
            {
                myArray[i] = default(T);
            }

            _Count = 0;
            Array.Resize(ref myArray, 0);
        }

        public bool Contains(T item)
        {
            foreach (T it in this)
            {
                if (it.Equals(item))
                {
                    return true;
                }
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            if (array.Length - arrayIndex < _Count)
            {
                throw new OverflowException();
            }

            for (int i = 0; i < _Count; i++)
            {
                array[arrayIndex + i] = myArray[i];
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < _Count; i++)
            {
                yield return myArray[i];
            }

        }

        public bool Remove(T item)
        {
            for (int i = 0; i < _Count; i++)
            {
                if (myArray[i].Equals(item))
                {
                    for (int j = i; j < _Count - 1; j++)
                    {
                        myArray[j] = myArray[j + 1];
                    }

                    myArray[_Count] = default(T);
                    _Count--;
                    return true;
                }
            }
            return false;

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
