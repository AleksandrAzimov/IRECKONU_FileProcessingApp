using IRECKONU_FileProcessingApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IRECKONU_FileProcessingApp.Data.Repositories.Interfaces
{
    public interface IItemsRepository : IGenericEFRepository<ItemModel>
    {
        Task BulkUpload(IEnumerable<ItemModel> items);
    }
}