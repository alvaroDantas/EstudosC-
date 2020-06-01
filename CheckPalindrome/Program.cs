using System;

namespace CheckPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Console.WriteLine(isPalidrome(str) ? "Palindrome":"Not Palindrome");
        }

        internal static bool isPalidrome(string str){
            bool check = false;
            int j = str.Length-1;

            for (int i = 0; i < str.Length / 2; i++, j--)
            {
                if(str[i] != str[j])
                    break;
                else{
                    check = true;
                }    
            }

            return check;
        }
    }
}
