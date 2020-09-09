using System;

namespace _2_task
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = { 1, 2, 5, 78, 2, 34, 248, 11, 9, 29, 0, 270 };
            int sum = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                sum += mas[i];
                Console.Write(mas[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Сумма масиву=" + sum);
            Console.ReadKey();
        }
    }
}
