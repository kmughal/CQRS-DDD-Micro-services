using System;

namespace CQRS.Sample
{
    public class Command : ICommand
    {
        public virtual string CommandName { get; }

        public Guid Id { get; } = Guid.NewGuid();
    }
}