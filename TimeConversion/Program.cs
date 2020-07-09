using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Globalization;


namespace TimeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(TimeConversion("07:05:45PM"));
        }

        internal static string TimeConversion(string str){
            DateTime time = new DateTime();
            try
            {
                time = DateTime.Parse(str);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }

            return time.ToString("HH:mm:ss", CultureInfo.InvariantCulture);
        }
    }
}
