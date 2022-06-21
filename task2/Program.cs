using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int num = 0;

            do
            {
                
                if (int.TryParse(Console.ReadLine(), out num))
                {
                    if (num > 0 && num % 2 == 1)
                        sum += num;
                }
                else
                {
                    num = 2;
                }


            } while (num != 0);

            Console.WriteLine("Sum: " + sum);
            Console.Write("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
