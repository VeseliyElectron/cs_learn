using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("================================");
            Console.WriteLine("Живилин Михаил");
            Console.WriteLine("================================");
            Console.WriteLine("Написать метод подсчета количества цифр числа.");
            Console.WriteLine("================================");

            int num;
                
                
                    Console.Write("Введите целое число: ");
                num = int.Parse(Console.ReadLine());

                num = Math.Abs(num);

                var count = -1;
                if (num == 0) count = 1;
                else while ((num / Math.Pow(10, ++count)) >= 1) ;

                Console.WriteLine($"В ведённом числе {count} знаков");
                Console.Write("Для выхода нажмите любую клавишу...");
                Console.ReadKey();
            
        }
    }
    
}
