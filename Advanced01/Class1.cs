using System.Collections;

namespace Advanced01
{
    #region Q1
    public class Range<T> where T : IComparable<T>
    {
        private T _min;
        private T _max;

        public Range(T min, T max)
        {
            _min = min;
            _max = max;
        }

        public bool IsInRange(T value)
        {
            return value.CompareTo(_min) >= 0 && value.CompareTo(_max) <= 0;
        }

        public dynamic Length()
        {
            if (typeof(T) == typeof(int))
            {
                return (dynamic)_max - (dynamic)_min;
            }
            else if (typeof(T) == typeof(double))
            {
                return (dynamic)_max - (dynamic)_min;
            }
            else
            {
                throw new InvalidOperationException("Unsupported type for Length calculation.");
            }
        }
        #region Q2
        public static void ReverseArrayList(ArrayList list)
        {
            int start = 0;
            int end = list.Count - 1;

            while (start < end)
            {
                object temp = list[start];
                list[start] = list[end];
                list[end] = temp;
                start++;
                end--;
            }
        }
        #endregion
        #region Q3
        public static List<int> FindEvenNumbers(List<int> numbers)
        {
            List<int> evenNumbers = new List<int>();

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenNumbers.Add(number);
                }
            }

            return evenNumbers;
        }
        #endregion
        #region Q5
        public static int FindFirstNonRepeatedChar(string str)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (char c in str)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                }
            }

            for (int i = 0; i < str.Length; i++)
            {
                if (charCount[str[i]] == 1)
                {
                    return i;
                }
            }

            return -1;
        }
        #endregion
    }

    #endregion
    #region Q4
    public class FixedSizeList<T>
    {
        private T _items;
        private int _capacity;
        private int _count;

        public FixedSizeList(int capacity)
        {
            _capacity = capacity;
            _items = new T[capacity];
            _count = 0;
        }

        public void Add(T item)
        {
            if (_count >= _capacity)
            {
                throw new InvalidOperationException("List is full.");
            }

            _items[_count] = item;
            _count++;
        }

        public T Get(int index)
        {
            if (index < 0 || index >= _count)
            {
                throw new IndexOutOfRangeException("Invalid index.");
            }

            return _items[index];
        }
    }
    #endregion

}
