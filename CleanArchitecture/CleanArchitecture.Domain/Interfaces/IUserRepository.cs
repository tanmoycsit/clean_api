using CleanArchitecture.Domain.Common.Interfaces;
using CleanArchitecture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Domain.Interfaces
{
    public interface IUserRepository : IBaseRepository<User>
    {
        public User GetCurrentUserInfo();
    }
}
