using Microsoft.Extensions.DependencyInjection;
using Mobile.Services.Abstractions;
using Mobile.Services.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileWebAPI
{
    public static class StartupExtensions
    {
        public static void RegisterDIServices(this IServiceCollection services)
        {
            services.AddScoped<IMobileService, MobileService>();
            services.AddScoped<IManufacturerService, ManufacturerService>();
        }
    }
}
