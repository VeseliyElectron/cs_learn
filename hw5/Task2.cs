using System;
using System.Linq;

namespace hw5
{
    class Task2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первую строку:");
            string s1 = Console.ReadLine();
            Console.WriteLine("Введите вторую строку:");
            string s2 = Console.ReadLine();

            if (s1.Select(Char.ToUpper).OrderBy(x => x).SequenceEqual(s2.Select(Char.ToUpper).OrderBy(x => x)))
            {
                Console.WriteLine("Перестановка обнаружена");
            }
            else
            {
                Console.WriteLine("Перестановка не обнаружена");
            }
            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}