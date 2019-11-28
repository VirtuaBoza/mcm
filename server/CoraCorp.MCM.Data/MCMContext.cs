using CoraCorp.MCM.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CoraCorp.MCM.Data
{
    public class MCMContext : DbContext
    {
        public MCMContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Work> Works { get; set; }
    }
}
