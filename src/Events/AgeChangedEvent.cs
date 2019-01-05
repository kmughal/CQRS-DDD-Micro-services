namespace CQRS.Sample
{
    using System;
    public class AgeChangedEvent : Event
    {
        public override string EventName { get; } = "Age_Changed_Event";

        public Person Target { get; }
        public int OldAge { get; }
        public int NewAge { get; }

        public AgeChangedEvent(Person person, int oldAge, int newAge)
        {
            Target = person;
            OldAge = oldAge;
            NewAge = newAge;
        }

        public override string ToString(){
            return $"{EventName},Old Age:{OldAge}, New Age:{NewAge}";
        }
    }
}