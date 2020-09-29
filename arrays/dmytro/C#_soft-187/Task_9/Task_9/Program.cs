using System;

namespace Task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { -3, 5, -6, 12, -22, 27 };
            for (int y = 0; y < array.Length; y++)
            {
                Console.Write(array[y] + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                    if (array[i] > 0)
                    {
                        ++array[i];
                        Console.Write(array[i] + " ");
                    }
                    else
                    {
                        --array[i];
                        Console.Write(array[i] + " ");
                    }
            }
            Console.ReadLine();
        }
    }
}