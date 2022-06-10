using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_learn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Анкета");
            Console.Write("Введите свое имя: ");
            String name = Console.ReadLine();
            Console.Write("Ведите свою фамилию:");
            String surname = Console.ReadLine();
            Console.Write("Ведите свой возраст: ");
            String age = Console.ReadLine();
            Console.Write("Ведите свой рост: ");
            String height = Console.ReadLine();
            Console.Write("Ведите свой вес: ");
            String weight = Console.ReadLine();
            Console.WriteLine("Ваше имя: " + name + ", Ваша фамилия: " + surname + ", Ваш возраст: " + age + ", Ваш рост: " + height + ", Ваш вес: " + weight);
            Console.WriteLine("Ваше имя: {0}, Ваша фамилия: {1}, Ваш возраст: {2}, Ваш рост: {3}, Ваш вес: {4}", name, surname, age, height, weight);
            Console.WriteLine($"Ваше имя: {name}, Ваша фамилия: {surname}, Ваш возраст: {age}, Ваш рост: {height} , Ваш вес: {weight} ");
            Console.Write("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();


        }
    }
}
