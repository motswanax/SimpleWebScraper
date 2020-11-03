using System;

namespace SimpleWebScraper
{
    class SuperPerson : Person
    {
        public SuperPerson(string FirstName, string LastName) : base(FirstName, LastName)
        {
        }

        public void Fly()
        {
            Console.WriteLine("I am flying. ");
        }
    }
} 
