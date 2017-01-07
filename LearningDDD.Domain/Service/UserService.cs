using LearningDDD.Domain.Entities;
using LearningDDD.Domain.Interfaces.Repository;
using LearningDDD.Domain.Interfaces.Services;

namespace LearningDDD.Domain.Service
{
    class UserService : ServiceBase<User>, IUserService
    {
        private readonly IUserRepository _repository;
        public UserService(IUserRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
