using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 10, 20, 5, 2, 8, 3 };

            int SumArray = 0;

            for (int i = 0; i < array.Length; i++)
            {
                SumArray = array[i] + SumArray;
            }

            Console.WriteLine(SumArray);

            Console.ReadLine();
        }
    }
}
