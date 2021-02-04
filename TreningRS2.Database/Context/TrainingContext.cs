using eTraining.Database.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eTraining.Model.Context
{
    public class TrainingContext: DbContext
    {

        public TrainingContext(DbContextOptions<TrainingContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Database.Entities.ApplicationUserRole>()
                .HasKey(e => new { e.ApplicationUserId, e.RoleId });
        }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<ApplicationUserRole> ApplicationUserRole { get; set; }
        public DbSet<Termin> Termin { get; set; }
        public DbSet<Clanarina> Clanarina { get; set; }
        public DbSet<Test> Test { get; set; }
        public DbSet<TestPolaznikTreningInstanca> TestPolaznikTreningInstanca { get; set; }
        public DbSet<Polaznik> Polaznik { get; set; }
        public DbSet<PolaznikTreningInstanca> PolaznikTreningInstanca { get; set; }
        public DbSet<Trening> Trening { get; set; }
        public DbSet<TreningInstanca> TreningInstanca { get; set; }
        public DbSet<Opcina> Opcina { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<TipUplate> TipUplate { get; set; }
        public DbSet<Uplata> Uplata { get; set; }
        public DbSet<Uposlenik> Uposlenik { get; set; }
    }
}
