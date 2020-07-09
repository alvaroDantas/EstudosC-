using System;
using System.Collections.Generic;
using System.Linq;

namespace GradingStudents
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> list = new List<int>() { 73, 67, 38, 33 };
            
            //gradingStudentsLinq(list);

            foreach (var item in gradingStudentsLinq(list))
            {
                System.Console.WriteLine(item);
            }
            

        }

        internal static List<int> gradingStudents(List<int> grades)
        {
            List<int> newList = new List<int>();

            foreach (int item in grades)
            {
                if ((item % 5) < 3 || item < 38)
                {
                    newList.Add(item);
                }
                else
                {
                    newList.Add(item + (5 - item % 5));
                }
            }

            foreach (var i in newList)
            {
                System.Console.WriteLine(i);
            }

            return newList;
        }

        internal static List<int> gradingStudentsLinq(List<int> grades)
        {
            return grades.Select( g => { 
                if(g % 5 < 3 || g < 38){
                    return g;
                }
                return g + (5 - g % 5);
            }).ToList();
        }
    }
}
