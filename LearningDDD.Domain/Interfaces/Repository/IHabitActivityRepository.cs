using LearningDDD.Domain.Entities;
using System.Collections.Generic;

namespace LearningDDD.Domain.Interfaces.Repository
{
    public interface IHabitActivityRepository : IRepositoryBase<HabitActivity>
    {
        IEnumerable<HabitActivity> GetByHabitId(int habitId);
    }
}
