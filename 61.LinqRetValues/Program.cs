﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _61.LinqRetValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** LINQ Return Values *****\n");
            IEnumerable<string> subset = GetStringSubset();
            foreach (string item in subset)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
        static IEnumerable<string> GetStringSubset()
        {
            string[] colors = {"Light Red","Green","Yellow",
                "Drak Red","Red","Purple"};
            IEnumerable<string> theRedColors = from c in colors
                                               where c.Contains("Red") select c;
            return theRedColors;
        }
        static string[] GetStringSubsetAsArray ()
        {
            string[] colors = {"Light Red","Green","Yellow",
                "Drak Red","Red","Purple"};
            var theRedColors = from c in colors
                               where c.Contains("Red")
                               select c;
            return theRedColors.ToArray();
        }
    }
}
