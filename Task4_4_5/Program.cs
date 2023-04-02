using System;

// Задание 4.4.5

// Заполните данный кортеж значениями аналогично примерам, разобранным в модуле выше.

namespace Task4_4_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string Name, string Type, double Age, int NameCount) Pet;

            Console.Write("Тип питомца: ");
            Pet.Type = Console.ReadLine();

            Console.Write("Кличка питомца: ");
            Pet.Name = Console.ReadLine();
            Pet.NameCount = Pet.Name.Length;

            Console.Write("Возраст питомца: ");
            Pet.Age = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine($"Тип питомца: {Pet.Type}\nКличка питомца: {Pet.Name}\nВозраст питомца: {Pet.Age}");
        }
    }
}
