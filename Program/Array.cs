using System;

namespace Program
{
    class Array
    {
        private int[] array;
        private Random random = new Random();

        public Array(int size)
        {
            array = new int[size];
        }

        public int this[int index]
        {
            get
            {
                if (index >= 0 && index < array.Length)
                {
                    return array[index];
                }

                Console.WriteLine("Iндекс виходить за межi масиву!");
                
                return 0;
            }
        }
        
        public int FindMaxElement()
        {
            int max = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            return max;
        }

        public int FindMinElement()
        {
            int min = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            return min;
        }
        
        public void FillRandom()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Елемент {i}: {array[i] = random.Next(1, 100)}");
            }
        }

        public void FillFromConsole()
        {
            Console.WriteLine("Введiть елементи масиву:");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Елемент {i}: ");
                
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        
        public void ScreenOutput()
        {
            foreach (var number in array)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
        }
    }
}