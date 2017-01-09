using LearningDDD.Domain.Entities;
using System.Collections.Generic;

namespace LearningDDD.Domain.Interfaces.Services
{
    public interface IHabitActivityService : IServiceBase<HabitActivity>
    {
        IEnumerable<HabitActivity> GetByHabitId(int habitId);
    }
}
