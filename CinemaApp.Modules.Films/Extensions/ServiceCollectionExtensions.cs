using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace CinemaApp.Modules.Films.Extensions
{
    internal class ServiceCollectionExtensions
    {
        pubic staic IServiceCollection AddFilmsModule(this IServiceCollection services)
        {
            return services;
        }
    }
}
