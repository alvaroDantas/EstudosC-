using System;

namespace MakingAnagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(makeAnagram("cde", "abc").ToString());
        }

        internal static int makeAnagram(string a, string b) {
        int[] aFrequencies = new int[26];
        int[] bFrequencies = new int[26];
        int minDel = 0;

        for (int i = 0; i < a.Length; i++)
        {
            char currentChar = a[i];
            int asciiChar = (int)currentChar;
            int pos = asciiChar - (int)'a';
            aFrequencies[pos]++;
        }

        for (int i = 0; i < b.Length; i++)
        {
            char currentChar = b[i];
            int asciiChar = (int)currentChar;
            int pos = asciiChar - (int)'a';
            bFrequencies[pos]++;
        }

        for (int i = 0; i < 26; i++)
        {
            int diff = Math.Abs(aFrequencies[i] - bFrequencies[i]);
            minDel+= diff;
        }

        return minDel;
    }
    }

    
}
