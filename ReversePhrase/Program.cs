using System;
using System.Text;
using System.Collections.Generic;

namespace ReversePhrase
{
  class Program
  {
    static void Main(string[] args)
    {
      System.Console.WriteLine("Type a phrase: ");
      string str = Console.ReadLine();
      Console.WriteLine($"\n\n{Reverse(str)}");

      Console.WriteLine($"\n\n{ReverseWords(str)}");

    }

    internal static string Reverse(string str)
    {
      int i;
      StringBuilder sb = new StringBuilder();

      int Start = str.Length - 1;
      int End = str.Length - 1;

      while (Start > 0)
      {
        if (str[Start] == ' ')
        {
          i = Start + 1;
          while (i <= End)
          {
            sb.Append(str[i]);
            i++;
          }
          sb.Append(' ');
          End = Start - 1;
        }
        Start--;
      }
      for (i = 0; i < End; i++)
      {
        sb.Append(str[i]);
      }

      return sb.ToString();
    }

    internal static string ReverseWords(string str)
    {
      StringBuilder output = new StringBuilder();
      List<char> charlist = new List<char>();

      for (int i = 0; i < str.Length; i++)
      {
        if (str[i] == ' ' || i == str.Length - 1)
        {
          if (i == str.Length - 1)
            charlist.Add(str[i]);
          for (int j = charlist.Count - 1; j >= 0; j--)
            output.Append(charlist[j]);

          output.Append(' ');
          charlist = new List<char>();
        }
        else
          charlist.Add(str[i]);
      }
      return output.ToString();
    }
  }
}
