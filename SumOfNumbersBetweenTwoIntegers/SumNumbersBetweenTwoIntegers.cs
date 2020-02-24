using System;

namespace SumOfNumbersBetweenTwoIntegers
{
    class SumNumbersBetweenTwoIntegers
    {
        //  First Attempt. Foundational
        public static int GetSum(int a, int b)
        {
            int outcome = 0;
            for (int x = a; x <= b; x++)
            {
                outcome += x;
            }
            for (int X = b; X <= a; X++)
            {
                outcome += X;
            }
            if (a == b)
            {
                outcome = a;
            }
            return outcome;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine(GetSum(-1, 5));
            Console.WriteLine(EfficientAnswer(-1, 5));
            string pin = "1, 2, 3, 4, 5";
            Console.WriteLine(int.Parse(pin));  
        }
        
            //  Final Copy, Most Efficient.
            public static int EfficientAnswer(int a, int b)
            {
                return (a + b) * (Math.Abs(a - b) + 1) / 2;
            }
        
    }
}
