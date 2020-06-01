using System;
using System.Collections.Generic;

namespace CountOccurrenceChar
{
  class Program
  {
    static void Main(string[] args)
    {
      System.Console.WriteLine("Type a phrase: ");
      string str = Console.ReadLine();
      CountOccurrence(str);
    }

    internal static void CountOccurrence(string str)
    {
      Dictionary<char, int> dic = new Dictionary<char, int>();

      foreach (var item in str)
      {
        if (item != ' ')
        {
          if (!dic.ContainsKey(item))
          {
            dic.Add(item, 1);
          }
          else
          {
            dic[item]++;
          }
        }
      }

      foreach (var i in dic)
      {
          System.Console.WriteLine($"Key: {i.Key}, Count: {i.Value}");
      }
    }
  }
}
