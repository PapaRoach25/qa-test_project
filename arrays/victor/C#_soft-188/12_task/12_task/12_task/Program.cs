using System;
using System.Linq;

namespace _12_task
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 91, 27, 54, 78, 25, 58 };
            int[] b = { 72, 109, 56 };

            Console.WriteLine("Перший массив");
            Console.WriteLine(string.Join(" ", a));

            Console.WriteLine("Другий массив");
            Console.WriteLine(string.Join(" ", b));
            Console.WriteLine("Конкатенацiя попереднiх масивiв");

            var result = a.Union(b);

            foreach (int s in result)
                
                Console.Write(s + ", ");
            Console.WriteLine();

        }
    }
}
