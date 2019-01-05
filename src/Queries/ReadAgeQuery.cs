namespace CQRS.Sample
{
    using System;

    public class ReadAgeQuery : EventArgs, IQuery
    {
        public object Result { get; set; }
        public Person Target { get; private set; }

        public ReadAgeQuery(Person person)
        {
            Target = person;
        }
    }
}