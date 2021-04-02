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
             new Shop { ShopId = 1, Name = "first shop", Goods = "yeehaw", Number = "1900"},
             new Shop { ShopId = 2, Name = "second shop", Goods = "second", Number = "livelinks"},
             new Shop { ShopId = 3, Name = "third shop", Goods = "third", Number = "goodbye c#"}
            
          );
        }

  
    
    
   
      public DbSet<Shop> Shops { get; set; }
       public DbSet<Restaurant> Restaurants { get; set; }

    
  }
}