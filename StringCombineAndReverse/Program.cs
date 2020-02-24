using System;

//  Your task is to Reverse and Combine Words.

//  1. More than one word? Reverse each word and combine first with second, third with fourth and so on...
//  (odd number of words => last one stays alone, but has to be reversed too)
//  2. Start it again until there's only one word without spaces

//  Thought Process: Overall I have a number of tasks, first I need to separate the string into the specified increments being after every other space
//  (every 2 words as the question states). Next I have to take those pieces of the string and reverse them. Once each segment is reversed, I need
//  to combine them into one single word.

//  Test case examples are "abc def" which should return "cbafed" and "abc def ghi jkl" which should return "defihglkj

namespace StringCombineAndReverse
{

    class Program
    {
        public static string reverseAndCombineText(string text)
        {
            char[] mychar = text.ToCharArray();
            Array.Reverse(mychar);
            string newText = new string(mychar);
            newText = newText.Replace(" ", "");
            return newText;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(reverseAndCombineText("\n\tabc def"));
            Console.WriteLine(reverseAndCombineText("\n\tabc def ghi jkl"));
        }
    }
}
