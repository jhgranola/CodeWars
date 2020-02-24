using System;

//  ATM machines allow 4 or 6 digit PIN codes and PIN codes cannot contain anything but exactly 4 digits or exactly 6 digits.
//  If the function is passed a valid PIN string, return true, else return false.
// TODO
namespace ValidatePin
{
    class Program
    {
        public static bool ValidatePin(string pin)
        {
            bool outcome = false;
            if (pinLength == 4 || pinLength == 7)
            {
                outcome = true;
            }
            else
            {
                outcome = false;
            }
            return outcome;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("ValidatePin.Program.Main");
            Console.WriteLine(ValidatePin("5, 6, 7, 8, 9, 1, 4"));
            string waffle = "1, 2, 3, 4, 5";
            Console.WriteLine(int.Parse(waffle));
        }
    }
}
