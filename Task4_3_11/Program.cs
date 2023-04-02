using System;

// Задание 4.3.11

// Напишите программу, которая отображает этот же массив, но только перебор начинается по столбцам.
// То есть сначала отображаем все знания строк первого столбца, потом второго и далее. 

namespace Task4_3_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = { { 1, 2, 3 }, { 5, 6, 7 }, { 8, 9, 10 }, { 11, 12, 13 } };

            for (int i = 0; i < array.GetUpperBound(1) + 1; i++)
            {
                for (int j = 0; j < array.GetUpperBound(0) + 1; j++)
                {
                    Console.Write(array[j, i] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
