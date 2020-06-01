using System;

namespace SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Type a number");
            var input = Int16.Parse(Console.ReadLine());
            System.Console.WriteLine($"Sum of {input} is {SumOfDigits(input).ToString()} ");

        }

        internal static int SumOfDigits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }
    }
}
