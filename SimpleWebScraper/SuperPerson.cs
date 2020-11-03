using System;

namespace SimpleWebScraper
{
    class SuperPerson : Person
    {
        public SuperPerson(string FirstName, string LastName, int Age, int EyeColor, int HairColor) : 
            base(FirstName, LastName, Age, EyeColor, HairColor)
        {
        }

        public void Fly()
        {
            Console.WriteLine("I am flying. ");
        }
    }
} 
