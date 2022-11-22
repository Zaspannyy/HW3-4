using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace HW3_list_
{


    class MyList<T>: IEnumerable<T>
    {
        T[] _items;
        int _size;
        private static readonly T[] s_emptyArray = new T[0];
        public int Capacity

        {
            get => _items.Length;
            set
            {

                if (value != _items.Length)
                {
                    if (value > 0)
                    {
                        T[] newItems = new T[value];
                        if (_size > 0)
                        {
                            Array.Copy(_items, newItems, _size);
                        }
                        _items = newItems;
                    }
                    else
                    {
                        _items = s_emptyArray;
                    }
                }
            }
        }
        public MyList()
        {
            _items = s_emptyArray;
        }
        public T this[int index]
        {
            get
            {
                return _items[index];
            }

            set
            {
                _items[index] = value;

            }

        }
        public MyList(int capacity)
        {
            if (capacity == 0)
                _items = s_emptyArray;
            else
                _items = new T[capacity];




        }
        private const int DefaultCapacity = 4;
        public void Add(T item)
        {
            T[] array = _items;
            int size = _size;
            if (size < _items.Length)
            {
                _size = size + 1;
                array[size] = item;
            }
            else
            {
                AddWithResize(item);
            }

        }
        private void AddWithResize(T item)
        {
            int size = _size;
            Grow(_size + 1);
            _size = size + 1;
            _items[size] = item;
        }

        private void Grow(int capacity)
        {
            int newcapacity = _items.Length == 0 ? DefaultCapacity : 2 * _items.Length;
           
            if (newcapacity < capacity)
                newcapacity = capacity;
            Capacity = newcapacity;
        }



        public void Insert(int index, T item)
        {
            if (_size == _items.Length)
                Grow(_size + 1);
            if (index < _size)
                Array.Copy(_items, index, _items, index + 1, _size - index);
            _items[index] = item;
            _size++;
        }

        public void RemoveAt(int index)
        {

            _size--;
            if (index < _size)
            {
                Array.Copy(_items, index + 1, _items, index, _size - index);
            }

        }

        public void Clear()
        {

            int size = _size;
            _size = 0;
            if (size > 0)
            {
                Array.Clear(_items, 0, size);
            }


        }


        public bool IsEmpty()
        {
            if (_size > 0)
            {
                return false;
            }
            else return true;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for(int i=0; i < _size; i++)
            {
                yield return _items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _items.GetEnumerator();
        }
    }
}
