using System;

// Задание 4.4.2

// Модифицируйте свою программу для ввода личной информации пользователя так, чтобы данные записывались в кортеж anketa.

namespace Task4_4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string name, int age) anketa;

            Console.Write("Введите свое имя: ");
            anketa.name = Console.ReadLine();

            Console.Write("Введите ваш возраст: ");
            anketa.age = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"Ваше имя: {anketa.name}\nВаш возраст: {anketa.age}");
        }
    }
}
