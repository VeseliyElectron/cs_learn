using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================================");
            Console.WriteLine("Живилин Михаил");
            Console.WriteLine("================================");
            Console.WriteLine("Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.");
            Console.WriteLine("================================");

            bool blocked = false;

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("Введите имя пользователя: ");
                String username = Console.ReadLine();
                Console.WriteLine("Введите пароль: ");
                String password = Console.ReadLine();

               if (Authorize(username, password))
                {
                    Console.WriteLine("Добро пожаловать в программу");
                    break;
                }
               else
                {
                    Console.WriteLine("Неправильный ввод пароля");
                }

               
                
            }
            Console.Write("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
        }

        static bool Authorize (String usr, String pwd)
        {
            const String usrBase = "root";
            const String pwdBase = "GeekBrains";
            if (usr == usrBase && pwd == pwdBase)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
