using System;
using Market.Domain.Entities;
using System.Data.Entity;

namespace Market.Domain.Concrete
{
  public  class EFDbContext : DbContext
    {
		public EFDbContext()
            :base("Market")
        { }
		public DbSet<Product> Products { get; set; }
    }
}
