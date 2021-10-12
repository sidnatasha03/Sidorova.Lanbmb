using System;


namespace Shershnev.Lab3.Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер диагонали доски: ");
            string diagonal = Console.ReadLine();

            string kolichestvo_shashek = "";

            switch (diagonal)
            {
                case "1a-8h":
                    Console.WriteLine(kolichestvo_shashek = "6");
                    break;

                case "1b-7h":
                    Console.WriteLine(kolichestvo_shashek = "0");
                    break;

                case "1c-6h":
                    Console.WriteLine(kolichestvo_shashek = "4");
                    break;

                case "1d-5h":
                    Console.WriteLine(kolichestvo_shashek = "0");
                    break;

                case "1e-4h":
                    Console.WriteLine(kolichestvo_shashek = "3");
                    break;

                case "1f-3h":
                    Console.WriteLine(kolichestvo_shashek = "0");
                    break;

                case "1g-2h":
                    Console.WriteLine(kolichestvo_shashek = "2");
                    break;

                case "1h-1h":
                    Console.WriteLine(kolichestvo_shashek = "0");
                    break;

                case "2a-8g":
                    Console.WriteLine(kolichestvo_shashek = "0");
                    break;

                case "3a-8f":
                    Console.WriteLine(kolichestvo_shashek = "4");
                    break;

                case "4a-8e":
                    Console.WriteLine(kolichestvo_shashek = "0");
                    break;

                case "5a-8d":
                    Console.WriteLine(kolichestvo_shashek = "3");
                    break;

                case "6a-8c":
                    Console.WriteLine(kolichestvo_shashek = "0");
                    break;

                case "7a-8b":
                    Console.WriteLine(kolichestvo_shashek = "2");
                    break;

                case "8a-8a":
                    Console.WriteLine(kolichestvo_shashek = "0");
                    break;
            }
        }
    }
}

