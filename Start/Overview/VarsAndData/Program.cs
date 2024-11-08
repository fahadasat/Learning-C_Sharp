﻿using System;

namespace VarsAndData
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare some basic value type variables
            int i = 10;
            float f = 2.0f;
            decimal d = 10.0m;
            bool b = true;
            char c = 'c';

            // Declare a string - it's a collection of characters
            string str = "a string";

            // Declare an implicit variable
            var x = 10;
            var z = "Hello!";

            // TODO: Declare an array of values
            int[] array = new int[5];
            string[] strs = {"one", "two", "three"};

            // TODO: Print the values using a Formatting String
            Console.WriteLine("{0}, {1}, {2}, {3}", i, c, z, strs[0]);

            // TODO: "null" means "no value"
            object obj = null;
            Console.WriteLine(obj);

            // TODO: Implicit conversion between types
            long bigNum;
            bigNum = i;

            // TODO: Explicit conversions
            float i_to_f = (float) i;
            Console.WriteLine("{0}", i_to_f);

            float f_to_i = (int) f;
            Console.WriteLine("{0}", f_to_i);
            Console.WriteLine("{0}", f);

        }
    }
}
