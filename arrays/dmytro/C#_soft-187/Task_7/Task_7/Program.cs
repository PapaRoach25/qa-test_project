using System;

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {  0, 0, 2, 0, - 2, 0, - 10, 0,  -1, 0  };
            int MaxEvenNumber = 0;
            int MinOddNumber = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    if (MaxEvenNumber < array[i])
                    {
                        MaxEvenNumber = array[i];
                    }
                    else if (MaxEvenNumber == 0)
                    {
                        MaxEvenNumber = array[i];
                    }
                }
            }

            for (int y = 0; y < array.Length; y++)
            {
                if (array[y] % 2 != 0)
                {
                    if (array[y] <= MinOddNumber)
                    {
                        MinOddNumber = array[y];
                    }
                    else if (MinOddNumber == 0)
                    {
                        MinOddNumber = array[y];
                    }
                }
            }

            Console.WriteLine("Maximum even value: " + MaxEvenNumber);
            Console.WriteLine("Minimum odd value: " + MinOddNumber);
            Console.ReadLine();
        }
    }
}