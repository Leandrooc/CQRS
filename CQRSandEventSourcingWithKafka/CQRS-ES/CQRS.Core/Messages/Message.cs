namespace CQRS.Core.Message
{
    public abstract class Message
    {
        public Guid Id { get; set; }
    }
}