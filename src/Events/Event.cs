namespace CQRS.Sample
{
    using System;
    public class Event : IEvent
    {
       public Guid Id { get; } = Guid.NewGuid();

      public virtual string EventName { get; }
    }
}