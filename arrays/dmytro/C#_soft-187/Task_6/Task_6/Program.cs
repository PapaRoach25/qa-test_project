using System;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 4, 22, 6, 8, 27, 4, 2, 25 };

            int sumArray = 0;
            int oddSumNambers = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 20)
                {
                    if (array[i] < 30)
                    {
                        if (array[i] % 2 == 0)
                        {
                            sumArray = array[i] + sumArray;
                            oddSumNambers++;
                        }
                    }
                }
            }

            Console.WriteLine("Сума четних чисел в диапазоне от 20 до 30 ровна: " + sumArray);
            Console.WriteLine("Количество четних чисел: " + oddSumNambers);
            Console.ReadLine();
        }
    }    
}
      
   