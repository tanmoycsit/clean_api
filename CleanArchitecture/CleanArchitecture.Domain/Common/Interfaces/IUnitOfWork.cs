using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Common.Interfaces
{
    public interface IUnitOfWork
    {
        Task<int> SaveChangesAsync();
    }
}
