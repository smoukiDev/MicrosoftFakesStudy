namespace MSFakesStudy.DataAccess
{
    using MSFakesStudy.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;

    public class ShopDbContext : DbContext
    {
        public ShopDbContext()
            : base("name=ShopDb")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Good>()
                .HasKey(e => e.Id);

            modelBuilder
                .Entity<Good>()
                .Property(e => e.Name)
                .HasColumnName("NAME");

            modelBuilder
                .Entity<Good>()
                .Property(e => e.Price)
                .HasColumnName("PRICE");
        }

        public virtual DbSet<Good> Goods { get; set; }

        public List<Good> GetGoodsByName(string name)
        {
            return this.Goods
                .Where(g => g.Name == name)
                .AsNoTracking()
                .ToList();
        }
    }
}