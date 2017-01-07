using LearningDDD.Application.Interfaces;
using LearningDDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace LearningDDD.Application
{
    public class AppServiceBase<Tentity> : IDisposable, IAppServiceBase<Tentity> where Tentity : class
    {
        private readonly IServiceBase<Tentity> _service;

        public AppServiceBase(IServiceBase<Tentity> service)
        {
            _service = service;
        }

        public void Add(Tentity obj)
        {
            _service.Add(obj);
        }

        public void Dispose()
        {
            _service.Dispose();
        }

        public IEnumerable<Tentity> GetAll()
        {
            return _service.GetAll();
        }

        public Tentity GetById(int id)
        {
            return _service.GetById(id);
        }

        public void Remove(Tentity obj)
        {
            _service.Remove(obj);
        }

        public void Update(Tentity obj)
        {
            _service.Update(obj);
        }
    }
}
