using System;

namespace _13_task
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 5, 78, 2, 34, 248, 11, 9, 29, 0, 270 };
            Console.WriteLine("1, 2, 5, 78, 2, 34, 248, 11, 9, 29, 0, 270 = даний масив.");
            int imax = 0;
            int imin = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[imin] > array[i])
                {
                    imin = i;
                }
                if (array[imax] < array[i])
                {
                    imax = i;
                }
            }

            int x = array[imin];
            array[imin] = array[imax];
            array[imax] = x;

            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + ", ");
                Console.Write(" = масив де замiнено максимальний елемент на мiнiмальний.");

            Console.ReadKey();
        }
    }
}
