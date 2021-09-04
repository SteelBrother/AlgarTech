using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDeveloperWEBAPI.Abstracciones;

namespace TestDeveloperWEBAPI.Repositorio
{
    public interface IRepositorio<T> : ICrud<T>
    {
    }
    public class Repositorio<T> : IRepositorio<T> where T : IEntity
    {
        IDbContext<T> _ctx;
        public Repositorio(IDbContext<T> dbContext)
        {
            _ctx = dbContext;
        }
        public void Delete(int id)
        {
            _ctx.Delete(id);
        }

        public void DeleteAsync(int id)
        {
            _ctx.DeleteAsync(id);
        }

        public IList<T> GetAll()
        {
            return _ctx.GetAll();
        }

        public Task<IList<T>> GetAllAsync()
        {
            return _ctx.GetAllAsync();
        }

        public T GetById(int id)
        {
            return _ctx.GetById(id);
        }

        public Task<T> GetByIdAsync(int id)
        {
            return _ctx.GetByIdAsync(id);
        }

        public T Save(T entity)
        {
            return _ctx.Save(entity);
        }

        public Task<T> SaveAsync(T entity)
        {
            return _ctx.SaveAsync(entity);
        }
    }
}
