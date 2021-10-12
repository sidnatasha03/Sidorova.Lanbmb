using System;

namespace Shershnev.Lab3.Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Присваиваем х, у и z значения, при которых выражение "f(x, y, z) = !z|!x&!z&!y" будет возвращать false
            bool x = true, y = true, z = true;
            Console.WriteLine(!z | !x & !z & !y); // вышло false

            bool x1 = false, y1 = false, z1 = false;
            Console.WriteLine(!z | !x & !z & !y); // вышло false

            bool x2 = false, y2 = false, z2 = true;
            Console.WriteLine(!z | !x & !z & !y); // вышло false

            bool x3 = true, y3 = false, z3 = false;
            Console.WriteLine(!z | !x & !z & !y); // вышло false

            bool x4 = false, y4 = true, z4 = false;
            Console.WriteLine(!z | !x & !z & !y); // вышло false  

            bool x5 = true, y6 = true, z6 = false;
            Console.WriteLine(!z | !x & !z & !y); // вышло false
        }
    }
}

