using System;

//Задание 4.3.17

// Одной из нетривиальных задач является задача сортировки двумерного массива. 
// Как минимум, не слишком понятно, как же сортировать, есть ведь «строки» и «столбцы». 
// Как требуется проводить сортировку?

// В данном случае давайте реализуем просто сортировку элементов массива внутри одной строки.  

namespace Task4_3_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
            int temp;

            for (int i = 0; i < arr.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < arr.GetUpperBound(1) + 1; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine("\n");

            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                {
                    for (int k = j + 1; k <= arr.GetUpperBound(1); k++)
                    {
                        if (arr[i, j] > arr[i, k])
                        {
                            temp = arr[i, k];
                            arr[i, k] = arr[i, j];
                            arr[i, j] = temp;
                        }                     
                    }   
                }
            }          
        }
    }
}
