using System;
using System.Text.RegularExpressions;

namespace SimpleWebScraper
{
    class Program
    {
        static void Main(string[] args)
        {
            MatchCollection matches = Regex.Matches("blah blah This is my cat blah blah", "This is my [a-z]at");

            foreach (var match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}