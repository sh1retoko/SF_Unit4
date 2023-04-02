using System;

// Задание 4.3.14

// Сделайте перебор массива массивов по аналогии с массивом строк.

namespace Task4_3_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] array = new int[3][];

            array[0] = new int[2] { 1, 2 };
            array[1] = new int[3] { 1, 2, 3 };
            array[2] = new int[5] { 1, 2, 3, 4, 5 };

            foreach (var item in array)
            {
                foreach (var temp in item)
                {
                    Console.Write(temp + " ");
                }
            }
        }
    }
}
