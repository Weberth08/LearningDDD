using LearningDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace LearningDDD.Infrastructure.Data.EntityConfig
{
    public class HabitAcitivityConfiguration : EntityTypeConfiguration<HabitActivity>
    {
        public HabitAcitivityConfiguration()
        {
            HasKey(h => h.HabitActivityId);
            ConfigureCompletedField();
            ConfigureRelationShip();

        }

        public void ConfigureCompletedField()
        {
            Property(p => p.Completed)
                .IsRequired();
        }

        public void ConfigureRelationShip()
        {
            // 1 Habit : N HabitActivity
            HasRequired<Habit>(h => h.Habit)
                .WithMany()
                .HasForeignKey(h => h.HabitId);
        }
    }
}
