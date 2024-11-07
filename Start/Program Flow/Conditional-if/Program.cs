using System;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            int theVal = 44;

            // TODO: if-else 
            if (theVal == 50) {
                Console.WriteLine("the val is 50");
            } else if (theVal == 51) {
                Console.WriteLine("the val is 51");
            } else {
                Console.WriteLine("the val is not 50 or 51");
            }

            // -----------------------
            // TODO: Using the ternary operator ?:

            // a two-case if-then
            /*
            if (theVal < 50) {
                Console.WriteLine("theVal is small");
            }
            else {
                Console.WriteLine("theVal is large");
            }
            */

            // TODO: can be replaced by a ternary operator ?:
            Console.WriteLine(theVal == 50 ? "the val is 50" : "the val is not 50");
        }
    }
}
