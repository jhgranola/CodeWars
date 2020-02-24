using System;

namespace EvenOrOdd
{
    class Program
    {
        public static string EvenOrOdd(int number)
        {
            string result = "";
            if (number % 2 == 0)
            { result = "Even"; }
            else
            { result = "Odd"; }
            return result;
        }
        public static string EvenOrOddQueryColon(int number)
        {
            return number % 2 == 0 ? "Even" : "Odd";
        }
        static void Main(string[] args)
        {
            Console.WriteLine(EvenOrOdd(7));
            Console.WriteLine(EvenOrOddQueryColon(7));
        }
    }
}