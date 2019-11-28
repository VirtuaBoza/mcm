namespace CoraCorp.MCM.App.Entities
{
    public interface IEntity<TId>
    {
        public TId Id { get; set; }
    }
}
