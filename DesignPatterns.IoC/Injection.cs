using DesignPatterns.Application.Interfaces;
using DesignPatterns.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.IoC
{
    public class Injection
    {
        public static void RegisterService(IServiceCollection services)
        {
            services.AddScoped<IUserServices, UserServices>();
        }
    }
}
