using System;


namespace Task_4
    {
        internal class Program
        {
            private static int IndexOF(int[] array, int value)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == value)
                    {
                        return i;
                    }
                }
                return -1;
            }

            private static void Main(string[] args)
            {
                int[] array = { 72, 26, 6, 10 };

                int minValue = array[0];

                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] < minValue)
                    {
                        minValue = array[i];
                    }
                }

                int result = IndexOF(array, minValue);

                Console.WriteLine("Индекс масива - " + result);
                Console.WriteLine("Минимальное значение елементов масива - " + minValue);
                Console.ReadLine();
            }
        }
    }

