using System;

//Задача

// Необходимо разработать методику анкетирования пользователей. 
// Требуется сохранять информацию:
// имени пользователя, фамилии, логине, длине логина, наличии/отсутствии у пользователя питомца, возрасте пользователя, трех любимых цветах пользователя.

namespace Practice_Task4_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string name, string lastName, int age, string login, int loginLength, bool pet, int agePet, string[] color) User;

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Введите ваше имя: ");
                User.name = Console.ReadLine();

                Console.Write("\nВведите вашу фамилию: ");
                User.lastName = Console.ReadLine();

                Console.Write("\nВведите ваш возраст: ");
                User.age = int.Parse(Console.ReadLine());

                Console.Write("\nВведите ваш логин: ");
                User.login = Console.ReadLine();
                User.loginLength = User.login.Length;

                Console.Write("\nУ вас есть питомцы 'Да' || 'Нет': ");
                var userPet = Console.ReadLine();

                int userAgePet = 0;

                if (userPet == "Да")
                {
                    Console.Write("\nВведите возраст питомца: ");
                    userAgePet = int.Parse(Console.ReadLine());
                }
                else
                {
                    User.pet = false;
                }

                User.agePet = userAgePet;

                Console.WriteLine();

                User.color = new string[3];

                for (int j = 0; j < User.color.Length; j++)
                {
                    Console.Write(j + 1 + ") Введите цвет: ");
                    User.color[j] = Console.ReadLine();
                }

                Console.WriteLine();
            }
        }
    }
}
