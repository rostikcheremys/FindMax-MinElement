using System;
using System.Linq;

namespace Program
{
    class Array
    {
        private int[] _array;
        private Random _random = new Random();

        public Array(int size)
        {
            _array = new int[size];
        }

        public int this[int index]
        {
            get
            {
                if (index >= 0 && index < _array.Length)
                {
                    return _array[index];
                }
                
                throw new IndexOutOfRangeException("Iндекс виходить за межі масиву!");
            }
        }
        
        public int FindMaxElement()
        {
            return _array.Max();
        }

        public int FindMinElement()
        {
            return _array.Min();
        }
        
        public void FillRandom()
        {
            for (int i = 0; i < _array.Length; i++)
            {
                Console.WriteLine($"Елемент {i}: {_array[i] = _random.Next(1, 100)}");
            }
        }

        public void FillFromConsole()
        {
            Console.WriteLine("Введiть елементи масиву:");

            for (int i = 0; i < _array.Length; i++)
            {
                Console.Write($"Елемент {i}: ");
                
                _array[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        
        public void ScreenOutput()
        {
            foreach (var number in _array)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
        }
    }
}