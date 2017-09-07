using System;

namespace TE15.Collections
{
    public class List
    {
        //Lägg till     (Add)
        //Hämta         (GetAt)
        //Hitta         (Find)
        //Ta bort       (RemoveAt)

        int[] _values;
        int _currentPosition;

        public int Count => _currentPosition;

        public List()
        {
            _values = new int[10];
            _currentPosition = 0;
        }

        public void Add(int value)
        {
            _values[_currentPosition++] = value;
        }

        public int GetAt(int position)
        {   
            if (position >= _currentPosition)
                throw new ArgumentOutOfRangeException();

            return _values[position];
        }

        public int Find(int value)
        {
            for (int i = 0; i < _currentPosition; i++)
            {
                if (_values[i] == value)
                    return i;
            }
            return -1;
        }

        public void RemoveAt(int position)
        {
            if (position >= _currentPosition)
                throw new ArgumentOutOfRangeException();
            for (int i = position; i < _currentPosition; i++)
            {
                _values[i] = _values[i + 1];
            }
            _currentPosition--;
        }

    }
}
