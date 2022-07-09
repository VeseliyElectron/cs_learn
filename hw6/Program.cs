using System;
// Описываем делегат. В делегате описывается сигнатура методов, на
// которые он сможет ссылаться в дальнейшем (хранить в себе)
public delegate double Fun(double x, double b);
class Program
{
    // Создаем метод, который принимает делегат
    // На практике этот метод сможет принимать любой метод
    // с такой же сигнатурой, как у делегата
    public static void Table(Fun F, double x, double b)
    {
        Console.WriteLine("----- X ----- Y -----");
        while (x <= b)
        {
            Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x, b));
            x += 1;
        }
        Console.WriteLine("---------------------");
    }
    // Создаем метод для передачи его в качестве параметра в Table
    public static double MyFunc(double x, double a)
    {
        return a * x * x;
    }
    public static double Sinus(double x, double a)
    {
        return a * Math.Sin(x);
    }
    static void Main()
    {
        Console.WriteLine("Таблица функции a*x^2:");
        Table(new Fun(MyFunc), -2, 2);
        Console.WriteLine("Таблица функции a*sin(x):");
        Table(new Fun(Sinus), -2, 2);
        Console.WriteLine("Для продолжения нажмите любую клавишу");
        Console.ReadKey();
    }
}