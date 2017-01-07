using LearningDDD.Application.Interfaces;
using LearningDDD.Domain.Entities;
using LearningDDD.Domain.Interfaces.Services;

namespace LearningDDD.Application
{
    class UserAppService : AppServiceBase<User>, IUserAppService
    {
        private readonly IUserService _service;

        public UserAppService(IUserService service) : base(service)
        {
            _service = service;
        }
    }
}
