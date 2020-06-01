using System;

namespace ReverseString
{
    class Program
    {

        delegate string Op(string str);
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            Op op = ReverseString;

            System.Console.WriteLine(op(str));

            //Console.WriteLine(ReverseString(str));
        }

        internal static string ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();
            int j = str.Length - 1;

            for (int i = 0; i < j; i++, j--)
            {
                charArray[i] = str[j];
                charArray[j] = str[i];
            }

            return new string(charArray);
        }
    }
}
