using System;

//      Alex just got a new hula hoop, he loves it but feels discouraged because his little brother is better than him
//      Write a program where Alex can input (n) how many times the hoop goes round and it will return him an encouraging message :)
//      -If Alex gets 10 or more hoops, return the string "Great, now move on to tricks".
//      -If he doesn't get 10 hoops, return the string "Keep at it until you get it".

//      Thought Process: The solution here is pretty simple. If (this) get that, if (this) get that). Sum it up ino an if else statement.
//      However, I am going to use this exercise to practice with query colons as a means to keep my code cleaner and shorter.



namespace HulaHoopMotivation
{
    class Program
    {
        public static string HoopCount(int n)
        {
            bool success = (n >= 10) ? true : false;
            string doIt = (success) ? "Great, now move on to tricks" : "Keep at it until you get it";
            return doIt;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("HulaHoopMotivation.Program.Main");
            Console.WriteLine(HoopCount(5));
        }
    }
}
