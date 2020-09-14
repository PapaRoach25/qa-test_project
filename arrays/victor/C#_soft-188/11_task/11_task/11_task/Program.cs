using System;


namespace _11_task
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 91, 27, 54, 78, 27, 54 };
            int[] b = { 78, 109, 56, 78, 72, 34 };

            if (a.Length > b.Length)
            {
                b = Enumerable.Range(0, a.Length - b.Length).Concat(b).ToArray();
            }
            else if (a.Length < b.Length)
            {
                a = Enumerable.Range(0, b.Length - a.Length).Concat(a).ToArray();
            }

            var c = a.Zip(b, (x, y) => x + y).ToArray();

            Console.WriteLine("Перший массив");
            Console.WriteLine(string.Join(" ", a));
            Console.WriteLine("Другий массив");
            Console.WriteLine(string.Join(" ", b));
            Console.WriteLine("Третiй масив. Попарна сума двох попереднiх");
            Console.WriteLine(string.Join(" ", c));
        }
    }
}