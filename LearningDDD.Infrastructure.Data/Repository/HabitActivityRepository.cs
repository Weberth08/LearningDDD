using LearningDDD.Domain.Entities;
using LearningDDD.Domain.Interfaces.Repository;
using System.Collections.Generic;
using System.Linq;

namespace LearningDDD.Infrastructure.Data.Repository
{
    public class HabitActivityRepository : RepositoryBase<HabitActivity>, IHabitActivityRepository
    {
        public IEnumerable<HabitActivity> GetByHabitId(int habitId)
        {
            return Db.HabitActivities.Where(ha => ha.HabitId == habitId).ToList();
        }
    }
}
