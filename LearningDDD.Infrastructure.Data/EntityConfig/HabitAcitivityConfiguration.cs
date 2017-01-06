using LearningDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace LearningDDD.Infrastructure.Data.EntityConfig
{
    public class HabitAcitivityConfiguration : EntityTypeConfiguration<HabitActivity>
    {
        public HabitAcitivityConfiguration()
        {
            HasKey(h => h.HabitId);
            ConfigureCompletedField();

        }

        public void ConfigureCompletedField()
        {
            Property(p => p.Completed)
                .IsRequired();
        }
    }
}
