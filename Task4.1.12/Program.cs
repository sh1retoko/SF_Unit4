using System;

// Задание 4.1.12

// Измените код так, чтобы отобразилось значение «условие истинно».

// var a = 6;
// var b = 7;

// if (a == b)
// {
//    Console.WriteLine("Условие истинно");
// }
// else
// {
//    Console.WriteLine("Условие ложно");
// }

namespace Task4_1_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 6;
            var b = 7;

            if (a != b)
            {
                Console.WriteLine("Условие истинно");
            }
            else
            {
                Console.WriteLine("Условие ложно");
            }
        }
    }
}
