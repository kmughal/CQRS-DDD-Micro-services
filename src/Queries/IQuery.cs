namespace CQRS.Sample
{
    public interface IQuery
    {
        object Result { get; set; }
    }
}