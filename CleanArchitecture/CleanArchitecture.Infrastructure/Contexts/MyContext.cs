using CleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Infrastructure.Contexts
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options, IConfiguration config)
          : base(options)
        {
            Configuration = config;
        }
        public IConfiguration Configuration { get; }

        public DbSet<User> Users { get; set; }
        public DbSet<UserHistory> UserHistories {get;set;}
    }
}
