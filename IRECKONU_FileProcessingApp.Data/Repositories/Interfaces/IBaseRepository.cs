using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IRECKONU_FileProcessingApp.Data.Repositories.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        Task InsertAsync(T obj);

        Task InsertManyAsync(IEnumerable<T> objs);
    }
}