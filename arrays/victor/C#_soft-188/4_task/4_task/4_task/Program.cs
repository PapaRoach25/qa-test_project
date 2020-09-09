using System;
using System.Linq;

namespace _4_task
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = { 1, 2, 5, 78, 2, 34, 248, 11, 9, 29, 0, 270 };
            Console.WriteLine("Масив = 1, 2, 5, 78, 2, 34, 248, 11, 9, 29, 0, 270");
            int minValue = mas.Min();
            int indexMin = Array.IndexOf(mas, minValue);
            Console.WriteLine("Мiнiмальний елемент масиву= " + minValue);
            Console.WriteLine("Iндекс елемента= " + indexMin);
            Console.ReadKey();
        }
    }
}
