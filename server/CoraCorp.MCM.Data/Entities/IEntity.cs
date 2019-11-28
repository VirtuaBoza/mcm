namespace CoraCorp.MCM.Data.Entities
{
    public interface IEntity<TId>
    {
        public TId Id { get; set; }
    }
}
