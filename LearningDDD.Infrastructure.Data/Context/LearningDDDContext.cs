using LearningDDD.Domain.Entities;
using LearningDDD.Infrastructure.Data.EntityConfig;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace LearningDDD.Infrastructure.Data.Context
{
    class LearningDDDContext : DbContext
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

            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());
            base.OnModelCreating(modelBuilder);
        }
    }
}
