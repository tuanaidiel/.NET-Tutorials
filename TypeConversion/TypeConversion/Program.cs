using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args) 
        {
            byte b = 1;
            int i = b;               //can convert byte to int
            Console.WriteLine(i);

            int e = 1;
            byte r = (byte) e;       //can't convert int to byte
            Console.WriteLine(r);

            int t = 1000;            //maximum byte is 255
            byte y = (byte)t;       
            Console.WriteLine(y);
        }
    }
}