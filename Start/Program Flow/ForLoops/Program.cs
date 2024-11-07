using System;

namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int myVal = 15;
            int[] nums = new int[] {3, 14, 15, 92, 6};
            string str = "The quick brown fox jumps over the lazy dog";

            // TODO: the basic for loop
            Console.WriteLine("The basic for loop:");
            for (int i = 0; i < nums.Length; i++) {
                Console.WriteLine(nums[i]);
            }

            Console.WriteLine();

            // TODO: the foreach-in loop can be used to iterate over sequences
            Console.WriteLine("The foreach loop:");
            foreach (int val in nums) {
                Console.WriteLine(val);
            }

            // TODO: count the number of o's in the string
            int count = 0;
            foreach (char val in str) {
            if(val == 'o') {
                    count++;
                }
            }
            Console.WriteLine("number of o's: {0}", count);
        }
    }
}
