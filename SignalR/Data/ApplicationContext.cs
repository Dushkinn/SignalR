using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SignalR.Models;
using Microsoft.AspNetCore.Identity;

namespace SignalR.Controllers
{
    public class ApplicationContext : IdentityDbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<BookItem> BookItems { get; set; }
        public DbSet<BookReservationRequest> BookReservationRequests { get; set; }
        public DbSet<BookType> BookTypes { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<ReservationBook> ReservationBooks { get; set; }
        public DbSet<StateType> StateTypes { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityUser>().ToTable("AspNetUsers");
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>(entity =>
            {
                entity.HasKey(e => e.ID);
                entity.Property(e => e.Name).IsRequired();
                entity.HasMany(d => d.Tags);
                entity.HasOne(d => d.BookType);
                entity.HasOne(d => d.Language);
            });

            modelBuilder.Entity<Author>(entity =>
            {
                entity.HasKey(e => e.Id);
            });
            modelBuilder.Entity<Tag>(entity =>
            {
                entity.HasKey(e => e.ID);
            });
        }

    }
   
}
