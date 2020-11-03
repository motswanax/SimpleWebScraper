namespace SimpleWebScraper
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Bad", "Man");
            person.Sleep();

            SuperPerson person1 = new SuperPerson("Super", "Man");
            person1.Sleep();
            person1.Fly();
        }
    }
} 
