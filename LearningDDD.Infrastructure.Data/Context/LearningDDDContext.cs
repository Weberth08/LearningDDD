using LearningDDD.Domain.Entities;
using LearningDDD.Infrastructure.Data.EntityConfig;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace LearningDDD.Infrastructure.Data.Context
{
    public class LearningDDDContext : DbContext
    {
        public LearningDDDContext() : base("LearningDDD")
        {

        }

        public DbSet<Habit> Habits { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<HabitActivity> HabitActivities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();

            modelBuilder.Configurations.Add(new HabitConfiguration());
            modelBuilder.Configurations.Add(new HabitAcitivityConfiguration());
            modelBuilder.Configurations.Add(new UserConfiguration());

            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());
            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("CreationDate") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("CreationDate").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("CreationDate").IsModified = false;
                }

            }
            return base.SaveChanges();
        }
    }
}
