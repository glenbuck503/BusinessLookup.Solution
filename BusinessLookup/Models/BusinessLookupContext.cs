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

  
    
    
      public DbSet<Restaurant> Restaurants { get; set; }
      public DbSet<Shop> Shops { get; set; }

    
  }
}