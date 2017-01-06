using LearningDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace LearningDDD.Infrastructure.Data.EntityConfig
{
    class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            HasKey(u => u.UserId);
            ConfigureFirstNameField();
            ConfigureLastNameField();
            ConfigureAliasField();
            ConfigureEmailField();
        }

        public void ConfigureFirstNameField()
        {
            Property(u => u.FirstName)
                .IsRequired();

        }

        public void ConfigureLastNameField()
        {
            Property(u => u.LastName)
                .IsRequired();

        }

        public void ConfigureAliasField()
        {
            Property(u => u.UserAlias)
                .IsRequired();

        }

        public void ConfigureEmailField()
        {
            Property(u => u.Email)
                .IsRequired();

        }
    }
}
