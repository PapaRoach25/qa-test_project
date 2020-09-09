using System;
using System.Linq;

namespace _13_task
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = { 1, 2, 5, 78, 2, 34, 248, 11, 9, 29, 0, 270 };
            Console.WriteLine("1, 2, 5, 78, 2, 34, 248, 11, 9, 29, 0, 270 = даний масив.");
            int imax = 0;
            int imin = 0;

            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[imin] > mas[i])
                {
                    imin = i;
                }
                if (mas[imax] < mas[i])
                {
                    imax = i;
                }
            }

            int x = mas[imin];
            mas[imin] = mas[imax];
            mas[imax] = x;

            Console.WriteLine();

            for (int i = 0; i < mas.Length; i++)
                Console.Write(mas[i] + ", ");
                Console.Write(" = масив де замiнено максимальний елемент на мiнiмальний.");

            Console.ReadKey();
        }
    }
}
