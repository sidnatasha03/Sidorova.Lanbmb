using System;

namespace Shershnev.Lab3.Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение x: ");
            string xstr = Console.ReadLine();
            //Конвертируем введённое пользователем значение х в double
            double x = Convert.ToDouble(xstr);
            //Задаём условия
            if (x > 250)
            {
                Console.WriteLine(Math.Abs(3 * x - 2));
            }
            if (0 <= x & x <= 250)
            {
                Console.WriteLine(Math.Abs(4 + x));
            }
            if (x < 0)
            {
                Console.WriteLine(Math.Abs(5 * x));
            }

        }

    }
}