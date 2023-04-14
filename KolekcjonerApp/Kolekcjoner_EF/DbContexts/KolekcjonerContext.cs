using KolekcjonerModel.Models;
using Microsoft.EntityFrameworkCore;
using Collection = KolekcjonerModel.Models.Collection;

namespace Kolekcjoner_EF.DbContexts;

public class KolekcjonerContext: DbContext
{
    public KolekcjonerContext()
    {
        
    }
    public DbSet<Collection> Collections { get; set; }
    public DbSet<CollectionDefinition> Type { get; set; }
    public DbSet<CollectionPosition> CollectionPositions { get; set; }
    public DbSet<PositionProperty> PositionProperties { get; set; }
    public DbSet<Property> Properties { get; set; }
    public DbSet<PropertyType> PropertyTypes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(Kolekcjoner_EF.ConectionString.CS, b=> b.MigrationsAssembly("KolekcjonerAPI"));
        base.OnConfiguring(optionsBuilder);
    }
}