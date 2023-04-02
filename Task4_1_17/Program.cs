using System;

// Задание 4.1.17

// Внесите программу в репозиторий, сделайте коммит об изменениях с указанием номера юнита.

namespace Task4_1_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите red || green цвет или будет дефолтный цвет: ");
            var color = Console.ReadLine();

            if (color == "red")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Вы выбрали красный цвет");
            }
            else if (color == "green")
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Вы выбрали зеленый цвет");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Вы ничего не выбрали. Ваш цвет по дефолту голубой");
            }

        }
    }
}
