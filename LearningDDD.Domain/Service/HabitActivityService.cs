using LearningDDD.Domain.Entities;
using LearningDDD.Domain.Interfaces.Repository;
using LearningDDD.Domain.Interfaces.Services;

namespace LearningDDD.Domain.Service
{
    public class HabitActivityService : ServiceBase<HabitActivity>, IHabitActivityService
    {
        private readonly IHabitActivityRepository _repository;
        public HabitActivityService(IHabitActivityRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
