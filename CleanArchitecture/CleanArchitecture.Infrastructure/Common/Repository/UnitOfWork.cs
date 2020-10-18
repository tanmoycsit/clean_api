using CleanArchitecture.Domain.Common.Interfaces;
using CleanArchitecture.Infrastructure.Contexts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Common.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        MyContext _dbContext;
        public UnitOfWork(MyContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<int> SaveChangesAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }
        private bool Disposed { get; set; }


        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (Disposed)
            {
                return;
            }

            if (disposing)
            {
                _dbContext.Dispose();
            }

            Disposed = true;
        }
    }
}
