using System;

namespace CountingValleys
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(method(8, "UDDDUDUU"));
        }

        internal static int method(int n, string str)
        {
            int valleys = 0;
            int level = 0;
            foreach (var item in str)
            {
                System.Console.WriteLine($"Valleys: {valleys}, level: {level}");

                if (item == 'D')
                {
                    level--;
                }
                else if (item == 'U')
                {
                    if (level == -1)
                    {
                        valleys++;
                    }
                    level++;
                }
            }

            return valleys;
        }
    }
}
