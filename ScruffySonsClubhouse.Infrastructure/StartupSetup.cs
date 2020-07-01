using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ScruffySonsClubhouse.Infrastructure.Data;

namespace ScruffySonsClubhouse.Infrastructure
{
    public static class StartupSetup
    {
        public static void AddDbContext(this IServiceCollection services, string connectionString) =>
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(connectionString)); // will be created in web project root
    }
}
