using MovieStore.Domain.Entities;
using System.Data.Entity;

namespace MovieStore.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
