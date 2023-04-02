using System;

// Задание 4.4.3

// Используя такую запись кортежа, измените предыдущую программу. Сначала отобразите на экран имя и возраст. 

// После этого попросите пользователя ввести эту же информацию с клавиатуры.

namespace Task4_4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var (name, age) = ("Евгения", 27);

            Console.WriteLine("Ваше имя: {0}", name);
            Console.WriteLine("Ваш возраст: {0}", age);

            Console.WriteLine();

            Console.Write("Введите имя: ");
            name = Console.ReadLine();

            Console.Write("Введите возраст: ");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Ваше имя: {0}", name);
            Console.WriteLine("Ваш возраст: {0}", age);
        }
    }
}
