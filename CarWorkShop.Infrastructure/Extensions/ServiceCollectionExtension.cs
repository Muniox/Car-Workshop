﻿using CarWorkshop.Application.ApplicationUser;
using CarWorkshop.Domain.Interfaces;
using CarWorkshop.Infrastructure.Persistence;
using CarWorkshop.Infrastructure.Repositories;
using CarWorkshop.Infrastructure.Seeders;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CarWorkshop.Infrastructure.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IUserContext, UserContext>();

            services.AddDbContext<CarWorkshopDbContext>(options => options.UseMySql(
                    configuration.GetConnectionString("CarWorkshop"),
                    new MariaDbServerVersion(new Version(10, 5, 0))
                    ));

            services.AddDefaultIdentity<IdentityUser>()
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<CarWorkshopDbContext>();

            services.AddScoped<CarWorkshopSeeder>();

            services.AddScoped<ICarWorkshopRepository, CarWorkshopRepository>();
            services.AddScoped<ICarWorkshopServiceRepository, CarWorkshopServiceRepository>();
        }
    }
}
