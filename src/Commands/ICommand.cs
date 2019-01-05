namespace CQRS.Sample
{
  using System;

  public interface ICommand
  {
    string CommandName { get; }
    Guid Id { get; }

  }
}