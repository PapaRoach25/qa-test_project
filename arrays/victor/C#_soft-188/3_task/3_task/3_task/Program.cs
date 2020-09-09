using System;

namespace _3_task
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = { 1, 2, 5, 78, 2, 34, 248, 11, 9, 29, 0, 270 };
            Console.WriteLine("Масив = 1, 2, 5, 78, 2, 34, 248, 11, 9, 29, 0, 270");
            Array.Sort(mas);
            int maxValue = mas[mas.Length - 1];
                Console.WriteLine("Максимальний елемент масиву= " + maxValue);
                Console.ReadKey();
        }
    }
}
