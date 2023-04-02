using System;

// Задание 4.1.18

// Добавьте в программу обработку ввода цвета cyan, а в блоке default поменяйте на желтый цвет фона, а цвет текста — на красный.

namespace Task4_1_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите red || green || cyan цвет или будет дефолтный цвет: ");

            switch (Console.ReadLine())
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Вы выбрали красный цвет");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Вы выбрали зеленый цвет");
                    break;

                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Вы выбрали голубой цвет");
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Вы ничего не выбрали. Ваш цвет по дефолту желтый");
                    break;
            }
        }
    }
}
