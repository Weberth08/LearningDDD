using LearningDDD.Application.Interfaces;
using LearningDDD.Domain.Entities;
using LearningDDD.Domain.Interfaces.Services;

namespace LearningDDD.Application
{
    public class HabitActivityAppService : AppServiceBase<HabitActivity>, IHabitActivityAppService
    {
        private readonly IHabitActivityService _service;

        public HabitActivityAppService(IHabitActivityService service) : base(service)
        {
            _service = service;
        }
    }
}
