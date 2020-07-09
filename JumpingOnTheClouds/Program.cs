using System;

namespace JumpingOnTheClouds
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        internal static int jumpingOnClouds(int[] c)
        {
            int i = 0;
            int jumps = 0;
            while (i < c.Length - 1)
            {
                if (i + 2 == c.Length || c[i + 2] == 1)
                {
                    jumps++;
                    i++;
                }
                else
                {
                    i += 2;
                    jumps++;
                }
            }
            return jumps;
        }
    }
}
