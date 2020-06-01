using System;
using System.Text;

namespace FindSubstrings
{
  class Program
  {
    static void Main(string[] args)
    {
        string str = System.Console.ReadLine();
        FindAllSubstring("abcd");
    }
    internal static void FindAllSubstring(string str)  
 {  
     for (int i = 0; i < str.Length; ++i)  
     {  
         StringBuilder subString = new StringBuilder(str.Length - i);  
         for (int j = i; j < str.Length; ++j)  
         {  
             subString.Append(str[j]);  
             Console.Write(subString + " ");  
         }  
     }  
 }
  }
}
