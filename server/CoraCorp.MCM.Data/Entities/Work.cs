namespace CoraCorp.MCM.Data.Entities
{
    public class Work : IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
