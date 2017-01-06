using LearningDDD.Domain.Entities;
using LearningDDD.Domain.Interfaces.Repository;

namespace LearningDDD.Infrastructure.Data.Repository
{
    class HabitActivityRepository : RepositoryBase<HabitActivity>, IHabitActivityRepository
    {
    }
}
