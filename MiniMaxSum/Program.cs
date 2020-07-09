using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;


namespace MiniMaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            MinMax(new int[]{1, 2, 3, 4, 5});
        }

        internal static void MinMax(int[] arr){
            Array.Sort(arr);
            long maxSum = arr.Skip(1).Sum(x => (long)x);
            long minSum = arr.Take(4).Sum(x => (long)x);

            Console.WriteLine($"{minSum} {maxSum}");
            
        }
    }
}
