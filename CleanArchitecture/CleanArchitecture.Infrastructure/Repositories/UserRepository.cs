using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Infrastructure.Common.Repository;
using CleanArchitecture.Infrastructure.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Infrastructure.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        private readonly MyContext _context;
        public UserRepository(MyContext context) : base(context)
        {
            _context = context;
        }

        public User GetCurrentUserInfo()
        {
            //fetch data from db
            var user = new User()
            {
                Id =1, DisplayName = "Tonmoy Chowdhury", NickName = "Tonmoy"
            };
            return user;
        }
    }
}
