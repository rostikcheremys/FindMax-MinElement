using System;

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

                Console.WriteLine("Iндекс виходить за межi масиву!");
                
                return 0;
            }
        }
        
        public int FindMaxElement()
        {
            int max = _array[0];

            for (int i = 1; i < _array.Length; i++)
            {
                if (_array[i] > max)
                {
                    max = _array[i];
                }
            }

            return max;
        }

        public int FindMinElement()
        {
            int min = _array[0];

            for (int i = 1; i < _array.Length; i++)
            {
                if (_array[i] < min)
                {
                    min = _array[i];
                }
            }

            return min;
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