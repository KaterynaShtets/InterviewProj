
using Microsoft.EntityFrameworkCore;
using System;
using CoreModel.Models;

namespace DataAccessLayer.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Interview> Interviews { get; set; }
        public DbSet<InterviewUser> InterviewUsers { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Technology> Technologies { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }

    
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Interview>()
            .HasData(
            new Interview { Id = 1, DateTime = new DateTime(2020, 6, 25, 16, 00, 0), GradeId = 1, PositionId = 1, RoomId = 1, TechnologyId = 1 });

        }
    }
}
