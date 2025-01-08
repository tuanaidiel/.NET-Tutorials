using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = "1234";
            int i = Convert.ToInt32(number);
            Console.WriteLine(i);

            try         //a function that use to prevent error
            {
                var numbers = "5678";
                byte b = Convert.ToByte(numbers);
                Console.WriteLine(b);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte.");
            }


            try         //a function that use to prevent error
            {
                string str = "true";
                bool j = Convert.ToBoolean(str);
                Console.WriteLine(j);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte.");
            }

        }
    }
}