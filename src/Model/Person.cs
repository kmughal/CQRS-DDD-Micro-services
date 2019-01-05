namespace CQRS.Sample
{
    using System.Collections.Generic;
    using System;

    public class Person
    {
        private readonly EventBroker _eb;
        private int age;
        public Person(EventBroker eb)
        {
            _eb = eb;
            _eb.Commands += BrokenOnCommand;
            _eb.Queries += BrokerOnQuery;
        }

        private void BrokerOnQuery(object sender, IQuery e)
        {
            var q = e as ReadAgeQuery;
            if (q != null && q.Target == this)
            {
                q.Result = age;
            }
        }

        private void BrokenOnCommand(object sender, ICommand cmd)
        {
            var ccmd = cmd as ChangeAgeCommand;
            if (ccmd != null && ccmd.Target == this)
            {
                _eb.AddEvent(new AgeChangedEvent(this, this.age, ccmd.NewAge));
                age = ccmd.NewAge;
            }
        }
    }
}