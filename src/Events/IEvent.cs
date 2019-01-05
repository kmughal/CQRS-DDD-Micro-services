namespace CQRS.Sample
{
    using System;
    public interface IEvent
    {
        Guid Id { get; }
        string EventName { get; }
    }
}