using System;
using System.Linq;
using System.Collections;
using System.Globalization;
using System.Collections.Generic;

namespace cw_two_sum
{
    public class Kata
    {
        public static int[] TwoSum(int[] numbers, int target)
        {
            for (int i = 0; i < numbers.Length-1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if ((numbers[i] + numbers[j]) == target)
                        return new int[] { i , j };
                }
                
            }
            
            return new int[] { -1, -1 };
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            
            // int arCount = Convert.ToInt32(Console.ReadLine().Trim());
            // List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();
            // Kata.TwoSum(new [] { 1, 2, 3 }, 4);

            var test = Kata.TwoSum(new [] { 1234, 5678, 9012 }, 14690).OrderBy(a => a).ToArray();
            foreach (var i in test) 
                Console.WriteLine(i);
        }
    }
}



