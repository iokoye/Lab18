using System;
using System.Collections.Generic;
using System.Text;

namespace Lab18
{
    public class LinkedList
    {
        private int _count = 0;
        private readonly string[] _array;

        public LinkedList(int maxLength)
        {
            _array = new string[maxLength];
        }

        public int Count()
        {
            return _count;
        }

        public bool IsEmpty()
        {
            return _count == 0;
        }

        public bool IsFull()
        {
            return _count == _array.Length;
        }

        public bool Insert(string value)
        {
            if (IsFull())
            {
                return false;
            }

            _array[_count] = value;
            _count++;
            return true;
        }

        public void RemoveAt(int index)
        {
            for (int i = index; i < _count; i++)
            {
                _array[i] = _array[i + 1];
            }

            _count--;
        }

        public string ReadAt(int index)
        {
            return _array[index];
        }

        public bool RemoveAt1(int index)
        {
            if (index > _array.Length) {
                return false;
            }
            for (int i = index; i < _count; i++)
            {
                _array[i] = _array[i + 1];
            }

            _count--;


            return true;
        }

        public void PrintReverse()
        {
            for (int i = (_array.Length - 1); i >= 0; i--)
            {
                Console.WriteLine(ReadAt(i));
            }
        }
        public bool InsertAt1(int index, Object value)
        {
      
            if (IsFull())
            {
                return false;
            }

            _array[index] = value.ToString();
            _count++;

            return false;
        }
    }
}
