using System;
using System.Linq;

namespace hw5
{
    class Task2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("������� ������ ������:");
            string s1 = Console.ReadLine();
            Console.WriteLine("������� ������ ������:");
            string s2 = Console.ReadLine();

            if (s1.Select(Char.ToUpper).OrderBy(x => x).SequenceEqual(s2.Select(Char.ToUpper).OrderBy(x => x)))
            {
                Console.WriteLine("������������ ����������");
            }
            else
            {
                Console.WriteLine("������������ �� ����������");
            }
            Console.WriteLine("��� ����������� ������� ����� �������...");
            Console.ReadKey();
        }
    }
}