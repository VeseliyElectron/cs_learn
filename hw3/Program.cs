using System;

namespace hw3
{
    class Complex
    {
        #region Public Methods

        /// <summary>
        /// Сложение комплексных чисел
        /// </summary>
        /// <param name="complex">Комплексное число</param>
        /// <returns>Результат сложения комплексных чисел</returns>
        public Complex Plus(Complex complex)
        {
            Complex c = new Complex();
            c.Re = _re + complex.Re;
            c._im = _im + complex._im;
            return c;
        }

        public Complex Minus(Complex complex)
        {
            Complex c = new Complex();
            c.Re = _re - complex.Re;
            c._im = _im - complex._im;
            return c;
        }

        public Complex Multiply(Complex complex)
        {
            Complex c = new Complex();
            c.Re = _re * complex.Re;
            c._im = _im * complex._im;
            return c;
        }

        /// <summary>
        /// Перегрузка оператора +, сложение комплексных чисел
        /// </summary>
        /// <param name="complex1">Комплексное число</param>
        /// <param name="complex2">Комплексное число</param>
        /// <returns>Результат сложения комплексных чисел</returns>
        public static Complex operator +(Complex complex1, Complex complex2)
        {
            return new Complex { Re = complex1.Re + complex2.Re, Im = complex1.Im + complex2.Im };
        }

        public override string ToString()
        {
            return $"{_re} {_im}i";
        }

        #endregion

        #region Constructors

        public Complex() { }

        public Complex(double re, double im)
        {
            _re = re;
            this._im = im;
        }

        #endregion

        #region Fields

        private double _re;
        private double _im;

        #endregion

        #region Properties

        public double Re
        {
            get { return _re; }
            set { _re = value; }
        }

        public double Im
        {
            get { return _im; }
            set { _im = value; }
        }

        #endregion
    }

    internal struct sComplex
    {
        public double im;
        public double re;

        public sComplex Plus(sComplex complex)
        {
            sComplex res;
            res.re = re + complex.re;
            res.im = im + complex.im;
            return res;
        }

        public sComplex Minus(sComplex complex)
        {
            sComplex res;
            res.re = re - complex.re;
            res.im = im - complex.im;
            return res;
        }

        public override string ToString()
        {
            return $"{re} + {im}i";
        }

    }



    class Program
    {
        static void Main(string[] args)
        {
            bool quit = false;
            while (true)
            {
                Console.WriteLine("Работу какого объекта вы хотите проверить?");
                Console.WriteLine("Сложение через структуру - введите s+");
                Console.WriteLine("Вычитание через структуру - введите s-");
                Console.WriteLine("Сложение через класс - введите c+");
                Console.WriteLine("Вычитание через класс - введите c-");
                Console.WriteLine("Умножение через класс - введите c*");
                Console.WriteLine("Выход из приложения - введите quit");
                switch (Console.ReadLine())
                {
                    case "s+":
                        Console.Clear();
                        Console.WriteLine("Сложение через структуру");
                        sComplex scomplex;

                        scomplex.re = 2;
                        scomplex.im = 3;


                        sComplex scomplex1;
                        scomplex1.re = -1;
                        scomplex1.im = -2;

                        sComplex scomplex2 = scomplex.Plus(scomplex1);

                        Console.WriteLine($"{scomplex}  +   {scomplex1}  = {scomplex2}");
                        break;
                    case "s-":
                        Console.Clear();
                        Console.WriteLine("Вычитание через структуру");
                        sComplex scomplex3;

                        scomplex3.re = 2;
                        scomplex3.im = 3;


                        sComplex scomplex4;
                        scomplex4.re = -1;
                        scomplex4.im = -2;

                        sComplex scomplex5 = scomplex3.Minus(scomplex4);

                        Console.WriteLine($"{scomplex3}  -   {scomplex4}  = {scomplex5}");
                        break;
                    case "c+":
                        Console.Clear();
                        Console.WriteLine("Сложение через класс");
                        Complex complex = new Complex(3, 4);
                        Complex complex1 = new Complex(1, 2);
                        Console.WriteLine($"{complex}  +   {complex1}  = {complex.Plus(complex1)}");
                        break;
                    case "c-":
                        Console.Clear();
                        Console.WriteLine("Вычитание через класс");
                        Complex complex2 = new Complex(3, 4);
                        Complex complex3 = new Complex(1, 2);
                        Console.WriteLine($"{complex2}  -   {complex3}  = {complex2.Minus(complex3)}");
                        break;
                    case "c*":
                        Console.Clear();
                        Console.WriteLine("Умножение через класс");
                        Complex complex4 = new Complex(3, 4);
                        Complex complex5 = new Complex(1, 2);
                        Console.WriteLine($"{complex4}  *   {complex5}  = {complex4.Multiply(complex5)}");
                        break;
                    case "quit":
                        quit = true;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Вы ввели некорректный модификатор запуска");
                        break;

                }

                if (quit)
                {
                    break;
                }
            }


            Console.Write("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
