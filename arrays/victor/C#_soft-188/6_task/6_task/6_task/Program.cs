using System;
using System.Linq;

namespace _6_task
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
                if (mas[i] >= 10 && mas[i] <= 100 && mas[i] %2 != 0)
                {
                    sum += mas[i];
                }
            }

            for (int j = 0; j < mas.Length; j++)
            {
                if (mas[j] >= 10 && mas[j] <= 100 && mas[j] % 2 != 0) { kl++; }
            }

            Console.WriteLine("Сума парних елементiв в дiaпазонi 10 - 100 = " + sum);
            Console.WriteLine("Кiлькiсть парних елементiв в дiaпазонi 10 - 100  = " + kl);
            Console.ReadLine();
        }
    }
}
