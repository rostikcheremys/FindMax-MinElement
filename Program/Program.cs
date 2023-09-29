using System;

namespace Program
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Оберiть спосiб заповнення масиву:");
            Console.WriteLine("Введiть 1 для вводу з клавiатури)");
            Console.WriteLine("Введiть 2 для вводу рандомно)");

            int choice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введiть розмiр масиву: ");
            int size = Convert.ToInt32(Console.ReadLine());

            Array array = new Array(size);
                
            switch (choice)
            {
                case 1:
                    array.FillFromConsole();
                    break;
                
                case 2 :
                    array.FillRandom();
                    break;
                
                default:
                    Console.WriteLine("Неправильний вибiр!");
                    break;
            }
                
            Console.WriteLine("Масив:");
            array.ScreenOutput();

            Console.WriteLine($"Максимальний елемент: {array.FindMaxElement()}");
            Console.WriteLine($"Мiнiмальний елемент: {array.FindMinElement()}");

            Console.Write("\nВведiть iндекс для отримання значення: ");
            
            int index = Convert.ToInt32(Console.ReadLine());
            int element = array.GetElement(index);
            
            Console.WriteLine($"Значення за iндексом {index}: {element}");
        }
    }
}