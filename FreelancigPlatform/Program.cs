using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;


namespace FreelancigPlatform
{
    class Program
    {
        static void Main(string[] args)
        {
            /* List<int> projectId = new List<int>() { 2, 0, 1, 2 };
            List<int> bid = new List<int>() { 8, 7, 6, 9 }; */

            List<int> projectId = new List<int>() { 0, 1, 0, 1, 1 };
            List<int> bid = new List<int>() { 4, 74, 47, 744, 7 };

            System.Console.WriteLine(minCost(2, projectId, bid).ToString());
        }

        internal static long minCost(int numProjects, List<int> projectId, List<int> bid)
        {
            var projectsBids = new Dictionary<int, List<int>>();
            int minValue = 0;

            List<int> projects = projectId.Distinct().ToList();


            if (projects.Count != numProjects)
            {
                return -1;
            }

            for (int i = 0; i < projects.Count; i++)
            {
                projectsBids.Add(projects[i], new List<int> { });
            }

            for (int i = 0; i < projects.Count; i++)
            {
                for (int j = 0; j < projectId.Count; j++)
                {
                    if (projectId[j] == projects[i])
                    {
                        projectsBids[projects[i]].Add(bid[j]);
                    }
                }
            }

            minValue = projectsBids.Select(_ => _.Value.Min()).Sum();

            return minValue;
        }





    }
}
