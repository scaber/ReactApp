using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) :base(options)
        {
        }
        public DbSet<Value> Values { get; set; }

      protected override void OnModelCreating (ModelBuilder builder)
      {
          builder.Entity<Value>()
          .HasData(
              new Value {Id=1,Name="Ankara"},
              new Value {Id=2,Name="Bursa"},
              new Value {Id=3,Name="İstanbul"},
              new Value {Id=4,Name="Eskişehir"},
              new Value {Id=5,Name="Adana"},
              new Value {Id=6,Name="İzmir"}
          );
      }
        
    }
}