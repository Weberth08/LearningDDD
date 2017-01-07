using LearningDDD.Application.Interfaces;
using LearningDDD.Domain.Entities;
using LearningDDD.Domain.Interfaces.Services;

namespace LearningDDD.Application
{
    class HabityActivityAppService : AppServiceBase<HabitActivity>, IHabitActivityAppService
    {
        private readonly IHabitActivityService _service;

        public HabityActivityAppService(IHabitActivityService service) : base(service)
        {
            _service = service;
        }
    }
}
