namespace CQRS.Sample
{
    using System;
    using static System.Console;

    class Program
    {
        static void Main(string[] args)
        {
            var eb = new EventBroker();
            var p = new Person(eb);
            eb.Command(new ChangeAgeCommand(p, 15));
            eb.Command(new ChangeAgeCommand(p, 25));
            eb.Command(new ChangeAgeCommand(p, 35));
            var age = eb.Query<int>(new ReadAgeQuery(p));
            WriteLine($"age:{age}");
            eb.ReplyAllEvents();
        }
    }
}