using System;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        { 

        int[] array = { 4, 5, 98, 23, 12, 19, 94 };

        int result = 0;
        int oddSumNambers = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                result += array[i];
                oddSumNambers++; 
            }
        }

        Console.WriteLine("Сума четних чисел ровна: " + result);
        Console.WriteLine("Количество четних чисел: " + oddSumNambers);
        Console.ReadLine();
        }
    }
}
