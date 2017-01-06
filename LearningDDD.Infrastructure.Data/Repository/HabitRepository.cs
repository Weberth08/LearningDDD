
using LearningDDD.Domain.Entities;
using LearningDDD.Domain.Interfaces.Repository;

namespace LearningDDD.Infrastructure.Data.Repository
{
    public class HabitRepository : RepositoryBase<Habit>, IHabitRepository
    {
    }
}
