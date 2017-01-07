using LearningDDD.Domain.Entities;
using LearningDDD.Domain.Interfaces.Repository;
using LearningDDD.Domain.Interfaces.Services;

namespace LearningDDD.Domain.Service
{
    public class HabitService : ServiceBase<Habit>, IHabitService
    {
        private readonly IHabitRepository _repository;
        public HabitService(IHabitRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
