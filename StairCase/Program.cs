using System;
using System.Text;

namespace StairCase
{
    class Program
    {
        static void Main(string[] args)
        {
            method(6);
        }

        internal static void method(int n)
        {
            for(int i = 1; i<=n; i++){
                StringBuilder sb = new StringBuilder(String.Empty);
                sb.Append(' ', n - i);
                sb.Append('#', i);
                System.Console.WriteLine(sb);
            }
        }
    }
}
