using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================================");
            Console.WriteLine("Живилин Михаил");
            Console.WriteLine("================================");
            Console.WriteLine("С клавиатуры вводятся числа, пока не будет введен 0.");
            Console.WriteLine("Подсчитать сумму всех нечетных положительных чисел.");
            Console.WriteLine("================================");

            int b = 0;
            while (true)
            {
                int a = int.Parse(Console.ReadLine());

                if (a != 0)
                {
                    if (a % 2 == 0 || Math.Sign(a) == -1)
                    { }
                    else
                        b += a;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine($"Сумма всех нечетных чисел: {b}");

            Console.Write("Для выхода нажмите любую клавишу...");
            Console.ReadKey(false);
        }
    }
}
