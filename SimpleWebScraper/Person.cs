using System;

namespace SimpleWebScraper
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }
        
        public void Walk()
        {
            Console.WriteLine("I am walking. ");
        }

        public void Eat()
        {
            Console.WriteLine("I am eating. ");
        }

        public void Sleep()
        {
            Console.WriteLine("I am sleeping. ");
        }
    }
}
