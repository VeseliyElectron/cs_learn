using System;
using System.IO;
namespace hw4
{
    public class MyArray
    {
        #region Private fields
        private int[] am;
        #endregion

        #region Constructor
        public MyArray(int[] arr)
        {
            am = arr;
        }

        public MyArray(string filename)
        {
                am = readFile(filename);

        }
        public MyArray(int n, int min, int max)
        {
            am = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
                am[i] = random.Next(min, max);
        }
        #endregion

        #region Public functions


        public int Divisibility3()
        {
            int count = 0;
            for (int i = 0; i < am.Length - 1; i++)
            {
                if (am[i] % 3 == 0 && am[i + 1] % 3 != 0 || am[i] % 3 != 0 && am[i + 1] % 3 == 0)
                    count++;
            }
            Console.WriteLine("Количество пар: " + count);
            return count;
        }


        override public string ToString()
        {
            string stringarray = "";
            foreach (int x in am)
                stringarray = stringarray + x + " ";
            return stringarray;
        }
        #endregion

        #region Private functions
        private int[] readFile(string filename)
        { 
            if (!File.Exists(filename))
                throw new FileNotFoundException();
            else
            {

                int[] buf = new int[1000];

                StreamReader streamReader = new StreamReader(filename);

                int counter = 0;
                while (!streamReader.EndOfStream)
                {
                    buf[counter] = int.Parse(streamReader.ReadLine());
                    counter++;
                }
                int[] res = new int[counter];
                Array.Copy(buf, res, counter);
                return res;
            }

            
        }
        #endregion

    }


    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] {6, 2, 9, -3, 6};
            try {
                Console.WriteLine("Количество пар для массива из файла");
                MyArray myFileArray = new MyArray("Text.txt");
                Console.WriteLine(myFileArray.ToString());
                myFileArray.Divisibility3();
            } catch (FileNotFoundException)
            {
                Console.WriteLine("Файл не найден");
            }
            Console.WriteLine("Количство пар для заданного массива");
            MyArray myArray = new MyArray(arr);
            Console.WriteLine(myArray.ToString());
            myArray.Divisibility3();
            Console.WriteLine("Количство пар для рандомного массива");
            MyArray myrndArray = new MyArray(20, -10000, 10000);
            Console.WriteLine(myrndArray.ToString());
            myrndArray.Divisibility3();
            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
