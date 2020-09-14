using System;

namespace _6_task
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 5, 78, 2, 34, 248, 11, 9, 29, 0, 270 };
            Console.WriteLine("Масив = 1, 2, 5, 78, 2, 34, 248, 11, 9, 29, 0, 270");
            int sum = 0;
            int numberOfPairElements = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 10 && array[i] <= 100 && array[i] %2 != 0)
                {
                    sum += array[i];
                    numberOfPairElements++;
                }
            }
            Console.WriteLine("Сума парних елементiв в дiaпазонi 10 - 100 = " + sum);
            Console.WriteLine("Кiлькiсть парних елементiв в дiaпазонi 10 - 100  = " + numberOfPairElements);
            Console.ReadLine();
        }
    }
}
