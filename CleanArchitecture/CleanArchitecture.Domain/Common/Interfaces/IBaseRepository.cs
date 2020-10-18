using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Common.Interfaces
{
    public interface IBaseRepository<T> where T: class
    {
        Task<T> GetById(int id);
        IQueryable<T> GetAllNoneDeleted(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        bool Commit();
        
    }
}
