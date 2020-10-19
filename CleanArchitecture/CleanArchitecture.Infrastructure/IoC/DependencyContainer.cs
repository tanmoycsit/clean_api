using CleanArchitecture.Domain.Common.Interfaces;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Infrastructure.Common.Repository;
using CleanArchitecture.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Infrastructure.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //CleanArchitecture.Application
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserHistoryRepository, UserHistoryRepository>();

            //CleanArchitecture.Domain.Interfaces | CleanArchitecture.Infra.Data.Repositories
            services.AddScoped<IUnitOfWork, UnitOfWork>();

        }
    }
}
