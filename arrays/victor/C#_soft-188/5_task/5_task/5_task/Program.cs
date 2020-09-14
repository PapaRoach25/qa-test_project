using System;

namespace _5_task
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 5, 78, 2, 34, 248, 110, 90, 29, 0, 270 };
            Console.WriteLine("Масив = 1, 2, 5, 78, 2, 34, 248, 110, 90, 29, 0, 270");
            int sum = 0;
            int numberOfPairElements = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    sum += array[i];
                    numberOfPairElements++;
                }
            }
            Console.WriteLine("Сума парних елементiв = " + sum);
            Console.WriteLine("Кiлькiсть парних елементiв = " + numberOfPairElements);
            Console.ReadLine();
        }
    }
}
