using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;


namespace BirthdayCakeCandles
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine(birthdayCakeCandles(new int[]{4, 4, 1, 3}).ToString());
            Console.WriteLine(BirthdayCakeCandles(new int[] { 4, 4, 1, 3 }).ToString());

        }

        internal static int birthdayCakeCandles(int[] ar)
        {
            int count = 1;
            int i = ar.Length - 2;
            Array.Sort(ar);
            while (ar[ar.Length - 1] == ar[i])
            {
                count++;
                i--;
            }
            return count;
        }

        internal static int BirthdayCakeCandles(int[] ar)
        {
            int[] p = new int[(int)Math.Pow(10, 7) + 1];
            int maxOccurrence = 0;


            foreach (var item in ar)
            {
                p[item]++;
                maxOccurrence = Math.Max(maxOccurrence, p[item]);

            }

            return maxOccurrence;

        }

    }
}
