using System;

// Задание 4.3.13

// Необходимо найти сумму всех его элементов.

namespace Task4_3_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
            int result = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                result += arr[i];
            }

            Console.WriteLine(result);
        }
    }
}
