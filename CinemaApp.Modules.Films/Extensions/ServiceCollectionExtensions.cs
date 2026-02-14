using CinemaApp.Modules.Films.Repositories;
using CinemaApp.Modules.Films.Repositories.Interfaces;
using CinemaApp.Modules.Films.Services;
using CinemaApp.Modules.Films.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace CinemaApp.Modules.Films.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddFilmsModule(this IServiceCollection services)
        {
            services.AddScoped<IMovieRepository, MovieRepository>();
            services.AddScoped<IMovieService, MovieService>();

            //добавиьт валидацию через FluentValidation
            //dotnet add package FluentValidation.DependencyInjectionExtensions 
            //services.AddValidatorsFromAssemblyContaining<FilmCreateValidator>();

            return services;
        }
    }
}