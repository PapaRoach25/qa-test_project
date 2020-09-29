using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6 };

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            for (int y = array.Length - 1; y >= 0; y--)
            {
                Console.WriteLine(array[y]);
            }
            Console.ReadLine();
        }
    }
}
