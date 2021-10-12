using System;

namespace Shershnev.Lab3.Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int y1, y2, m1, m2, d1, d2;
            Console.WriteLine("Год: ");
            y1 = Convert.ToInt32(Console.ReadLine());
            if (y1 <= 2021)
            {
                Console.WriteLine("Месяц: ");
            }
            else
            {
                Console.WriteLine("Ошибка");

            }
            m1 = Convert.ToInt32(Console.ReadLine());
            if (m1 <= 12 & m1 >= 1)
            {
                Console.WriteLine("День: ");
            }
            else
            {
                Console.WriteLine("Ошибка");
            }
            d1 = Convert.ToInt32(Console.ReadLine());

            if (m1 == 2 && d1 > 28)
            {
                Console.WriteLine("В феврале 28 дней (кроме високосного года)");
            }
           
            if (m1 == 4 && d1 >= 31)
            {
                Console.WriteLine("В апреле 30 дней");
            }
           
            if (m1 == 6 && d1 >= 31)
            {
                Console.WriteLine("В июне 30 дней");
            }
           
            if (m1 == 9 && d1 >= 31)
            {
                Console.WriteLine("В сентябре 30 дней");
            }
            
            if (m1 == 11 && d1 >= 31)
            {
                Console.WriteLine("В ноябре 30 дней");
            }

            if (d1 <= 31 & d1 >= 1)
            {
                Console.WriteLine();
                Console.WriteLine("Введите дату рождения 2 человека");
                Console.WriteLine();
                Console.WriteLine("Год: ");
                y2 = Convert.ToInt32(Console.ReadLine());
                if (y2 <= 2021)
                {
                    Console.WriteLine("Месяц: ");
                }
                else
                {
                    Console.WriteLine("Ошибка");
                }
                m2 = Convert.ToInt32(Console.ReadLine());
                if (m2 <= 12 & m2 >= 1)
                {
                    Console.WriteLine("День: ");
                }
                else
                {
                    Console.WriteLine("Ошибка");
                }
                d2 = Convert.ToInt32(Console.ReadLine());
                if (m2 == 2 && d2 > 28)
                {
                    Console.WriteLine("В феврале 28 дней (кроме високосного года)");
                }

                if (m2 == 4 && d2 >= 31)
                {
                    Console.WriteLine("В апреле 30 дней");
                }

                if (m2 == 6 && d2 >= 31)
                {
                    Console.WriteLine("В июне 30 дней");
                }

                if (m2 == 9 && d2 >= 31)
                {
                    Console.WriteLine("В сентябре 30 дней");
                }

                if (m2 == 11 && d2 >= 31)
                {
                    Console.WriteLine("В ноябре 30 дней");
                }

                if (d2 <= 31 & d2 >= 1)
                {
                    if (y1 <= y2 & m1 <= m2 & d1 < d2)
                    {
                        Console.WriteLine("1 человек старше 2");
                    }
                    if (y1 >= y2 & m1 >= m2 & d1 > d2)
                    {
                        Console.WriteLine("2 человек старше 1");
                    }
                    if (y1 == y2 & m1 == m2 & d1 == d2)
                    {
                        Console.WriteLine("Они ровесники");
                    }
                }

                else
                {
                    Console.WriteLine("Ошибка");
                }
            }
            else
            {
                Console.WriteLine("Ошибка");
            }


        }
    
    }
}



