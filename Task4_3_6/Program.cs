using System;

// Задание 4.3.7

// Напишите программу, которая переставляет буквы вашего имени в обратном порядке.

namespace Task4_3_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите свое имя: ");

            var name = Console.ReadLine();

            for (int i = name.Length - 1; i >= 0; i--)
            {
                Console.Write(name[i] + " ");
            }
        }
    }
}
