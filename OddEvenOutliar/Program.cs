using System;

//  You are given an array(which will have a length of at least 3, but could be very large) containing integers.
//  The array is either entirely comprised of odd integers or entirely comprised of even integers except for a single integer N.
//  Write a method that takes the array as an argument and returns this "outlier" N.

    //   Thought Process: An array can be dissected using a for loop in order to assess each value given in the array.
    //      To check the value to see if it's odd or even, we can use if statements in combination with math to assume if its odd or even
    //      based on if it can be evenly divided by 2.
    //      Then, I can return the singular value by establishing a count of odd and even numbers, and return the value who's count is equal to 1.


namespace OddEvenOutliar
{
    class Program
    {
        // Let's Give this a shot
         public static int FindOutliar(int[] integers)
         {
            int result = 0;
            int currentEvenNumber = 0;
            int currentOddNumber = 0;
            int oddcount = 0;
            int evencount = 0;
            for (int i = 0; i < integers.Length; i++)
             {
                 if (integers[i] % 2 == 0)
                 {
                     evencount++;
                    currentEvenNumber = integers[i];
                 }
                 else if (integers[i] % 2 != 0)
                 {
                     oddcount++;
                    currentOddNumber = integers[i];
                 }
            }
            if (oddcount == 1)
            {
                result = currentOddNumber;
            }
            else if (evencount == 1)
            {
                result = currentEvenNumber;
            }
            return result;
         }

        //      IT WORKS! Time to clean it up a little.

        public static int Find(int[] integers)
        {
            int evenCount = 0;
            int oddCount = 0;
            int currentEvenNumber = 0;
            int currentOddNumber = 0;
            foreach (int integer in integers)
            {
                if (integer % 2 == 1)
                {
                    oddCount++;
                    currentOddNumber = integer;
                }
                else
                {
                    evenCount++;
                    currentEvenNumber = integer;
                }
            }
            return (oddCount > evenCount) ? currentEvenNumber : currentOddNumber;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("OddEvenOutliar.Program.Main");
            Console.WriteLine(FindOutliar());
            Console.WriteLine(Find());
        }
    }
}
