using System;

namespace IsPrime
{
  class Program
  {
    static void Main(string[] args)
    {
      double n;
      System.Console.WriteLine("Type a number:");
      n = Double.Parse(System.Console.ReadLine());

      System.Console.WriteLine(checkIsPrime(n) ? "Prime" : "Not Prime");

    }

    internal static bool checkIsPrime(double n)
    {
      if (n == 1)
        return false;
      if (n == 2)
        return true;

      int squareRoot = (int)Math.Floor(Math.Sqrt(n));

      for (int i = 3; i <= squareRoot; i += 2)
      {
        if (n % i == 0)
          return false;
      }

      return false;
    }
  }
}
