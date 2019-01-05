namespace CQRS.Sample
{
    using System.Collections.Generic;
    using System;

    public class EventBroker
    {
        private static readonly IList<IEvent> _allEvents = new List<IEvent>();

        public event EventHandler<ICommand> Commands;

        public event EventHandler<IQuery> Queries;

        public void Command(ICommand cmd)
        {
            Commands?.Invoke(this, cmd);
        }

        public T Query<T>(IQuery query)
        {
            Queries?.Invoke(this, query);
            return (T) query.Result;
        }

        public void AddEvent(IEvent @event)
        {
            _allEvents.Add(@event);
        }

        public void ReplyAllEvents()
        {
            foreach (var @event in _allEvents)
            {
                Console.WriteLine(@event.ToString());
            }
        }
    }
}