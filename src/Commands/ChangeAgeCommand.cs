namespace CQRS.Sample
{
    using System;

    public class ChangeAgeCommand : EventArgs, ICommand
    {
        public Person Target { private set; get; }
        public int NewAge { private set; get; }

        public string CommandName =>
            "Change_Age_Command";

        public Guid Id => Guid.NewGuid();

        public ChangeAgeCommand(Person person, int newAge)
        {
            Target = person;
            NewAge = newAge;
        }
    }
}