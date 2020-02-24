using System;
using System.Linq;
namespace StringReverse
{
    class Program
    {
        // First Attempt - Using Substring
        public static string Solution(string str)
        {
            if (str.Length <= 1) return str;
            else return Solution(str.Substring(1)) + str[0];
        }

        // Alternate Attempt - Using Arrays
        public static string SolutionArray(string str)
        {
            return new string(str.ToArray().Reverse().ToArray());
        }
    
        static void Main(string[] args)
        {
            Console.WriteLine(Solution("world"));
            Console.WriteLine(SolutionArray("world"));

        }
    }
}
