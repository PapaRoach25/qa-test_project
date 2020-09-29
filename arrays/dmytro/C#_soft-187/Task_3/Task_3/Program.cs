using System;


namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 72, 26, 6, 10, };

            int minValue = array[0];
            
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < minValue)
                {
                    minValue = array[i];
                }
            }

            Console.WriteLine(minValue);        
            Console.ReadLine();
        }
    }
}
