using System;

namespace _1_task
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 5, 78, 2, 34, 248, 11, 9, 29, 0, 270 };
            foreach (var v in array)
                Console.Write (v + " ");
                Console.WriteLine();
                
            Array.Reverse(array);
            foreach (int x in array)
                Console.Write(x + " ");
        }
}
}
