using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDeveloperWEBAPI.Abstracciones;
using TestDeveloperWEBAPI.Repositorio;

namespace TestDeveloperWEBAPI.Negocio
{
    public interface IAplicacion<T> : ICrud<T>
    {
    }


    public class Aplicacion<T> : IAplicacion<T> where T : IEntity
    {
        //All the operations necessary for the application are created
        IRepositorio<T> _repository;
        public Aplicacion(IRepositorio<T> repository)
        {
            _repository = repository;
        }
        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public void DeleteAsync(int id)
        {
            _repository.DeleteAsync(id);
        }

        public IList<T> GetAll()
        {
            return _repository.GetAll();
        }

        public Task<IList<T>> GetAllAsync()
        {
            return _repository.GetAllAsync();
        }

        public T GetById(int id)
        {
            return _repository.GetById(id);
        }

        public Task<T> GetByIdAsync(int id)
        {
            return _repository.GetByIdAsync(id);
        }

        public T Save(T entity)
        {
            return _repository.Save(entity);
        }

        public Task<T> SaveAsync(T entity)
        {
            return _repository.SaveAsync(entity);
        }
    }
}
