using System;

namespace _2_task
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 5, 78, 2, 34, 248, 11, 9, 29, 0, 270 };
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Сумма масиву=" + sum);
            Console.ReadKey();
        }
    }
}
