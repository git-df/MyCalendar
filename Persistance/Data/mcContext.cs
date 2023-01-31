﻿using Domain.Entity;
using Domain.Entity.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Persistance.DummyData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Data
{
    public class mcContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<AccesRequest> AccesRequests { get; set; }

        public mcContext(DbContextOptions<mcContext> options) : base(options) { }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Modified:
                        entry.Entity.ModifiedDate = DateTime.UtcNow;
                        break;
                    case EntityState.Added:
                        entry.Entity.CreatedDate = DateTime.UtcNow;
                        break;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>(e =>
            {
                e.HasMany(x => x.Comments)
                    .WithOne(y => y.Event)
                    .HasForeignKey(y => y.EventId)
                    .OnDelete(DeleteBehavior.NoAction);
            });

            modelBuilder.Entity<User>(e =>
            {
                e.HasMany(x => x.Events)
                    .WithOne(y => y.User)
                    .HasForeignKey(y => y.UserId)
                    .OnDelete(DeleteBehavior.NoAction);

                e.HasMany(x => x.accesRequestsToUser)
                    .WithOne(y => y.ToUser)
                    .HasForeignKey(y => y.ToUserId)
                    .OnDelete(DeleteBehavior.NoAction);

                e.HasMany(x => x.accesRequestsFromUser)
                    .WithOne(y => y.FromUser)
                    .HasForeignKey(y => y.FromUserId)
                    .OnDelete(DeleteBehavior.NoAction);

                e.HasMany(x => x.Comments)
                    .WithOne(y => y.User)
                    .HasForeignKey(y => y.UserId)
                    .OnDelete(DeleteBehavior.NoAction);
            });

            foreach (var item in DummyUsers.GetUsers())
            {
                modelBuilder.Entity<User>().HasData(item);
            }

            foreach (var item in DummyEvents.GetEvents())
            {
                modelBuilder.Entity<Event>().HasData(item);
            }

            foreach (var item in DummyComments.GetComments())
            {
                modelBuilder.Entity<Comment>().HasData(item);
            }

            foreach (var item in DummyAccesRequests.GetAccesRequests())
            {
                modelBuilder.Entity<AccesRequest>().HasData(item);
            }
        }
    }
}
