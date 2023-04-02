using System;

// Задание 4.3.15

// Задайте одномерный массив и напишите алгоритм, который находит в нем количество положительных чисел.

namespace Task4_3_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { -5, 6, -9, 1, 2, 3, 4, -2, 0 };

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    Console.WriteLine(arr[i]);
                }               
            }
        }
    }
}
