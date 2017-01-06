using LearningDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace LearningDDD.Infrastructure.Data.EntityConfig
{
    public class HabitConfiguration : EntityTypeConfiguration<Habit>
    {
        public HabitConfiguration()
        {
            HasKey(h => h.HabitId);
            ConfigureDescriptionField();
            ConfigureIsActiveField();
            ConfigureCreationDateField();


        }

        private void ConfigureDescriptionField()
        {

            Property(p => p.Description)
               .IsRequired();
        }

        private void ConfigureIsActiveField()
        {

            Property(p => p.Active)
               .IsRequired();
        }

        private void ConfigureCreationDateField()
        {
            Property(p => p.CreationDate)
                .IsOptional();


        }

    }
}


