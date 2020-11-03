namespace SimpleWebScraper
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new PersonBuilder().Build();
            Person person1 = new PersonBuilder().WithAge(35).Build();
            Person person2 = new PersonBuilder().WithAge(39).Build();
        }
    }
}