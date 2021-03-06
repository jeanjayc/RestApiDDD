using System.Collections.Generic;
using RestApiModeloDDD.Domain.Core.Interfaces.Repositories;
using RestApiModeloDDD.Domain.Core.Interfaces.Services;

namespace RestApiModeloDDD.Domain.Services
{
    public class ServiceBase<TEntity>: IServiceBase<TEntity>where TEntity: class
    {
        private readonly IRepositoryBase<TEntity> _repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }
        public void Add(TEntity obj)
        {
            _repository.Add(obj);
        }

        public void Update(TEntity obj)
        {
            _repository.Update(obj);
        }

        public void Remove(TEntity obj)
        {
            _repository.Remove(obj);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public TEntity GetById(int id)
        {
            return _repository.GetById(id);
        }
    }
}