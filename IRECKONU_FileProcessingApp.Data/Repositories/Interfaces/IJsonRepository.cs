using System;
using System.Collections.Generic;
using System.Text;

namespace IRECKONU_FileProcessingApp.Data.Repositories.Interfaces
{
    public interface IJsonRepository<T> : IBaseRepository<T> where T : class
    {
    }
}