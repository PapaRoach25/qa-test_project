using System;

namespace Task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3, -5, 8, -12, 6, -1 };
            int InverseElement;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    Console.WriteLine(array[i]);
                }
                else
                {
                    InverseElement = array[i] * -1;
                    Console.WriteLine(InverseElement);
                }
            }
            Console.ReadLine();
        }
    }
}


