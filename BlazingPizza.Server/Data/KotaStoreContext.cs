﻿using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace BlazingPizza.Server
{
    public class KotaStoreContext : ApiAuthorizationDbContext<PizzaStoreUser>
    {
        public KotaStoreContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Kota> Pizzas { get; set; }

        public DbSet<KotaSpecial> Specials { get; set; }

        public DbSet<Topping> Toppings { get; set; }

        public DbSet<NotificationSubscription> NotificationSubscriptions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuring a many-to-many special -> topping relationship that is friendly for serialization
            modelBuilder.Entity<KotaTopping>().HasKey(pst => new { pst.KotaId, pst.ToppingId });
            modelBuilder.Entity<KotaTopping>().HasOne<Kota>().WithMany(ps => ps.Toppings);
            modelBuilder.Entity<KotaTopping>().HasOne(pst => pst.Topping).WithMany();

            // Inline the Lat-Long pairs in Order rather than having a FK to another table
            modelBuilder.Entity<Order>().OwnsOne(o => o.DeliveryLocation);
        }
    }
}