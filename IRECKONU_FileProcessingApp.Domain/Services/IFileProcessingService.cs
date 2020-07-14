using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IRECKONU_FileProcessingApp.Domain.Services
{
    public interface IFileProcessingService
    {
        Task ProcessFile(byte[] file);
    }
}