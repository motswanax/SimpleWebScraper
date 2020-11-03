using System;

namespace SimpleWebScraper
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int EyeColor { get; set; }
        public int HairColor { get; set; }

        public Person(string FirstName, string LastName, int Age, int EyeColor, int HairColor)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
            this.EyeColor = EyeColor;
            this.HairColor = HairColor;
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
