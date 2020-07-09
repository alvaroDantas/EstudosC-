using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace PlusMinus
{
    class Program
    {
        static void Main(string[] args)
        {
            method(new int[] { -4, 3, -9, 0, 4, 1 });

        }

        internal static void method(int[] arr)
        {
            double positives = 0;
            double negatives = 0;
            double zeros = 0;
            int n = arr.Length;

            foreach (var i in arr)
            {
                if (i > 0)
                {
                    positives++;
                }
                else if (i < 0)
                {
                    negatives++;
                }
                else
                {
                    zeros++;
                }
            }
            double frPositives = positives / n;
            double frNegatives = negatives / n;
            double frZeros = zeros / n;

            System.Console.WriteLine(frPositives.ToString("F6"));
            System.Console.WriteLine(frNegatives.ToString("F6"));
            System.Console.WriteLine(frZeros.ToString("F6"));

            
        }
    }
}
