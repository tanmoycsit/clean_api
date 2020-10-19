using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Infrastructure.Common.Repository;
using CleanArchitecture.Infrastructure.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Infrastructure.Repositories
{
    public class UserHistoryRepository : BaseRepository<UserHistory>, IUserHistoryRepository
    {
        private readonly MyContext _context;
        public UserHistoryRepository(MyContext context) : base(context)
        {
            _context = context;
        }
    }
}
