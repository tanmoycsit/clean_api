using CleanArchitecture.Domain.Common.Entities;
using CleanArchitecture.Domain.Common.Interfaces;
using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Common.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private readonly MyContext _context;
        private readonly DbSet<T> _dbset;
        //public IUnitOfWork UnitOfWork => throw new NotImplementedException();

        public BaseRepository(MyContext context)
        {
            _context = context;
            _dbset = context.Set<T>();
        }

        public int _currentUser { get; set; }
        public int CurrentUser { 
            get {
                _currentUser = 1;
                return _currentUser;
            }
        }
        public void Add(T entity)
        {
            entity.CreatedBy = CurrentUser;
            entity.CreatedDate = DateTime.Now;
            _context.Add(entity);
        }

        public bool Commit()
        {
            var rowCommits = _context.SaveChanges();
            return rowCommits > 0;
        }

        public void Delete(T entity)
        {
            entity.IsDeleted = true;
            entity.DeletedBy = _currentUser;
            entity.DeletedDate = DateTime.Now;
            _context.Entry(entity).State = EntityState.Modified;
        }

        public IQueryable<T> GetAllNoneDeleted(int id)
        {
            IQueryable<T> query = _dbset.Where(s => s.IsDeleted == false);
            return query;
        }

        public async Task<T> GetById(int id)
        {
            T entity = await _dbset.SingleOrDefaultAsync(s => s.Id == id);
            return entity;
        }

        public void Update(T entity)
        {
            entity.ModifiedBy = _currentUser;
            entity.ModifiedDate = DateTime.Now;
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
