using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 1;
            var b = 2;

            Console.WriteLine(a + b);

            var c = 3;
            var d = 4;
            var e = 5;

            Console.WriteLine(e < d || e == c);  //False
        }
    }
}