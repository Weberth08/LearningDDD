using LearningDDD.Application.Interfaces;
using LearningDDD.Domain.Entities;
using LearningDDD.Domain.Interfaces.Services;

namespace LearningDDD.Application
{
    public class HabitAppService : AppServiceBase<Habit>, IHabitAppService
    {
        private readonly IHabitService _service;
        public HabitAppService(IHabitService service) : base(service)
        {
            _service = service;
        }
    }
}
