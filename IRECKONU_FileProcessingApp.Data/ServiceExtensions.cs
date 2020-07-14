using IRECKONU_FileProcessingApp.Data.Repositories;
using IRECKONU_FileProcessingApp.Data.Repositories.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace IRECKONU_FileProcessingApp.Data
{
    public static class ServiceExtensions
    {
        public static void AddDataServices(this IServiceCollection services)
        {
            services.AddTransient(typeof(IGenericEFRepository<>), typeof(GenericEFRepository<>));
            services.AddTransient(typeof(IItemsRepository), typeof(ItemsRepository));
            services.AddTransient(typeof(IJsonRepository<>), typeof(JsonRepository<>));
        }
    }
}