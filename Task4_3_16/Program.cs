using System;

// Задание 4.3.16

// Необходимо найти количество положительных элементов массива.

namespace Task4_3_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };

            foreach (var item in arr)
            {
                if (item > 0)
                {
                    Console.Write(item + " ");
                }
            }

            Console.WriteLine();
        }
    }
}
