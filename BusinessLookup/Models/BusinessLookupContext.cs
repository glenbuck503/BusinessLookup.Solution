using Microsoft.EntityFrameworkCore;
using System;

namespace BusinessLookup.Models
{
  public class BusinessLookupContext : DbContext
  {
    public BusinessLookupContext(DbContextOptions<BusinessLookupContext> options)
      : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
        {
          builder.Entity<Shop>()
          .HasData(
             new Shop { ShopId = 1, Name = "dfdsfs", Goods = "yeehaw", Number = "7"}
            
          );
        }

  
    
    
   
      public DbSet<Shop> Shops { get; set; }
       public DbSet<Restaurant> Restaurants { get; set; }

    
  }
}