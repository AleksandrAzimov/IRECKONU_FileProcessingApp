using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IRECKONU_FileProcessingApp.Data.Repositories.Interfaces
{
    public interface IGenericEFRepository<T> : IBaseRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();

        Task<T> GetByIdAsync(object id);

        void Update(T obj);

        void Delete(object id);

        Task SaveAsync();
    }
}