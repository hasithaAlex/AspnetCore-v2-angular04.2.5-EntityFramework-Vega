using AspnetCore_angular04_EntityFramework_Vega_2.Models;
using Microsoft.EntityFrameworkCore;

namespace AspnetCore_angular04_EntityFramework_Vega_2.Persistence
{
    public class VegaDbContext : DbContext
    {
       // oldway -> this way change in entity framework core more lovely couple fashion
       // public VigaDbContext(string connectionString) : base(connectionString) { }
       
       // newway 
       // DbContextOptions is new class
        public VegaDbContext(DbContextOptions<VegaDbContext> options) : base(options)
        {
        
        }

        public DbSet<Make> Makes { get; set; }    
        public DbSet<Feature> Features { get; set; }    
            
    }
}