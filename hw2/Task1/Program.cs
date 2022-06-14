using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int second = int.Parse(Console.ReadLine());
            Console.Write("Введите третье число: ");
            int third = int.Parse(Console.ReadLine());
            int max = maxInt(first, second, third);
            Console.WriteLine($"Максимальное число, которое вы ввели это {max}");
        }

        static int maxInt(int a, int b, int c)
        {
            if (b < a && a > c)
            {
                return a;
            }
            else if (a < b && b > c)
            {
                return b;
            }
            else
            {
                return c;
            }

        }
    }
}