using Microsoft.Extensions.DependencyInjection;
using IRECKONU_FileProcessingApp.Domain.Services;
using IRECKONU_FileProcessingApp.Domain.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace IRECKONU_FileProcessingApp.Domain
{
    public static class ServiceExtensions
    {
        public static void AddDomainServices(this IServiceCollection services)
        {
            services.AddTransient(typeof(IFileProcessingService), typeof(FileProcessingService));
            services.AddTransient(typeof(ICsvFileReader), typeof(CsvFileReader));
        }
    }
}