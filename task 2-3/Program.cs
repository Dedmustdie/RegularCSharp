﻿using System;
using System.Text.RegularExpressions;

namespace task_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string sTime = "ухйцайцуацуацуа цу 10:00 цуацу апцуацуац";
            foreach (var item in sTime.TimeSearch())
                Console.WriteLine(item);

            string sMac = "ухйцайцуацуацуа цу 10:00 цуа aB:dC:cA:56:76:54 цу апцуацуац";
            foreach (var item in sMac.MacSearch())
                Console.WriteLine(item);


        }

    }
    public static class StringExtension
    {
        public static MatchCollection TimeSearch(this string str)
        {
            var regex = new Regex(@"(([0-1][0-9])|([2][0-3])):[0-6][0-9]");
            return regex.Matches(str);
        }

        public static MatchCollection MacSearch(this string str)
        {
            var regex = new Regex(@"([a-z][a-z]:){3}([0-9][0-9]:){2}[0-9]", RegexOptions.IgnoreCase);
            return regex.Matches(str);
        }


    }

}