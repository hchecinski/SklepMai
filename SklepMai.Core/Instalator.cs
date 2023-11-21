using System.Reflection;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace SklepMai.Core
{
    public static class Instalator
    {
        public static IServiceCollection Setup(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(x => x.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

            return services;
        }
    }
}