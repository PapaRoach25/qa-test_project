using System;

namespace _3_task
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 5, 78, 2, 34, 248, 11, 9, 29, 0, 270 };
            Console.WriteLine("Масив = 1, 2, 5, 78, 2, 34, 248, 11, 9, 29, 0, 270");
            
            int max = array[0];
                        
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            Console.WriteLine("Максимальний елемент масиву= " + max);
            Console.ReadKey();
        }
    }
}
