using System;

namespace _4_task
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 10, 2, 5, 78, 2, 34, 248, 11, 9, 29, 3, 270 };
            Console.WriteLine("Масив = 10, 2, 5, 78, 2, 34, 248, 11, 9, 29, 3, 2700");
            int min = array[0];
            int indexOfMinElement = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    indexOfMinElement = i;
                }
            }
            Console.WriteLine("Мiнiмальний елемент масиву= " + min);
            Console.WriteLine("Iндекс мiнiмального елементу масиву= " + indexOfMinElement);
            Console.ReadKey();
        }
    }
}
