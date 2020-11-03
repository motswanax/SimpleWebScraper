using System;

namespace SimpleWebScraper
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "Bad";
            person.LastName = "Man";

            Console.WriteLine(person.FirstName);
            Console.WriteLine(person.LastName);
            Console.WriteLine(person.HasProperDocuments);

            person.FirstName = "";
            Console.WriteLine(person.FirstName);
        }
    }
} 
