using System;
using System.Linq;
using System.Collections.Generic;

namespace SocketMerchant
{
    class Program
    {
        static void Main(string[] args)
        {
            int pairs = sockMerchant(9, new int[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 });

            System.Console.WriteLine($" Numbers of pairs: {pairs.ToString()}");


        }

        internal static int sockMerchant(int n, int[] ar)
        {
            int numPairs = 0;
            ISet<int> hashSet = new HashSet<int>();
            
            ar.ToList().ForEach(x => {
                System.Console.WriteLine($"hashSet.Contains({x}): , {hashSet.Contains(x).ToString()}");
                if(hashSet.Contains(x)){
                    hashSet.Remove(x);
                    numPairs++;
                }
                else{
                    hashSet.Add(x);
                }
            });

            return numPairs;

        }
    }
}
