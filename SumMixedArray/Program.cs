using System;

        // TODO:
namespace SumMixedArray
{
    class Program
    {
        public static int SumMix(object[] x)
        {
            int sum = 0;
            for (int i = 0; i < x.Length; i++)
            {
                sum += x[i];
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(SumMix("5", "0", 9, 3, 2, 1, "9", 6, 7));
        }
    }
}
