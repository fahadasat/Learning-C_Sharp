using System;

namespace ConditionalOps
{
    class Program
    {
        static void Main(string[] args)
        {
            int theVal = 50;

            // TODO: The switch statement
            switch (theVal) {
                case 50:
                    Console.WriteLine("val is 50");
                    break;
                case 51:
                    Console.WriteLine("val is 51");
                    break;
                case 55:
                case 52:
                case 53:
                case 54:
                    Console.WriteLine("val is between 51 and 55");
                    break;
                default:
                    Console.WriteLine("val is not known");
                    break;
            }
        }
    }
}
