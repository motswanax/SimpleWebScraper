using System;

namespace SimpleWebScraper
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleCalculator simpleCalculator = new SimpleCalculator();

            var scenario1 = true;
            if (scenario1)
            {
                Console.WriteLine("Answer is {0}", simpleCalculator.Add(1, 2));
            }
            else
            {
                Console.WriteLine(simpleCalculator.Add(1, 2));
            }
        }
    }
}