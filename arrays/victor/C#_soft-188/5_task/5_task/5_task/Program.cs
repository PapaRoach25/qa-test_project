using System;
using System.Linq;

namespace _5_task
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = { 1, 2, 5, 78, 2, 34, 248, 11, 9, 29, 0, 270 };
            Console.WriteLine("Масив = 1, 2, 5, 78, 2, 34, 248, 11, 9, 29, 0, 270");
            int sum = 0;
            int kl = 1;

            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] %2 == 0)
                {
                    sum += mas[i];
                }
            }

            for (int j = 0; j < mas.Length; j++)
            {
                if (mas[j] % 2 != 0) { kl++; }
            }

            Console.WriteLine("Сума парних елементiв = " + sum);
            Console.WriteLine("Кiлькiсть парних елементiв = " + kl);
            Console.ReadLine();
        }
    }
}
