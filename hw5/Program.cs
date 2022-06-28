using System;
using System.Globalization;
using System.Text.RegularExpressions;
namespace hw5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите логин:");
            string login = Console.ReadLine();
            Regex login_regex = new Regex("^[a-zA-Zа-яА-Я][a-zA-Zа-яА-Я0-9]{2,9}$");
            //С регулярками не разобрался, получилось только с русскими символами.
            if (login_regex.Match(login).Success) // если совпадение удачно
            {
                Console.WriteLine("Логин введен верно");
            }
            else
            {
                Console.WriteLine("Логин введен неверно. Логин должен быть от 2 до 10 символов в длину, содержать в себе только латиницу, и начинаться с буквы.");
            }
            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
