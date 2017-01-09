using System.Collections.Generic;
using LearningDDD.Domain.Entities;

namespace LearningDDD.Application.Interfaces
{
    public interface IHabitActivityAppService : IAppServiceBase<HabitActivity>
    {
        IEnumerable<HabitActivity> GetByHabitId(int habitId);
    }
}
