﻿using System;
using System.Text;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            int jumpCount = 10;
            string[] animals = {"goats", "cats", "pigs"};

            // TODO: create a StringBuilder
            StringBuilder sb = new StringBuilder("Initial String.", 200);
            
            // TODO: print some basic stats about the StringBuilder
            Console.WriteLine($"Capacity: {sb.Capacity}, Length: {sb.Length}");

            // TODO: Add some strings to the builder using Append
            sb.Append("Test code");

            // TODO: AppendLine can append a line ending
            sb.AppendLine();

            // TODO: AppendFormat can be used to append formatted strings
            sb.AppendFormat("he did this {0} times.", jumpCount);

            // TODO: AppendJoin can iterate over a set of values
            sb.AppendJoin(',', animals);

            // TODO: Modify the content using Replace
            sb.Replace("he", "she");

            // TODO: Insert content at any index
            sb.Insert(0, "testing");
            Console.WriteLine($"Capacity: {sb.Capacity}, Length: {sb.Length}");
            // TODO: Convert to a single string
            Console.WriteLine(sb.ToString());
        }
    }
}
