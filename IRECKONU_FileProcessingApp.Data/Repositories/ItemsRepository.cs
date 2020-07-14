using EFCore.BulkExtensions;
using IRECKONU_FileProcessingApp.Data.Contexts;
using IRECKONU_FileProcessingApp.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using IRECKONU_FileProcessingApp.Data.Repositories.Interfaces;

namespace IRECKONU_FileProcessingApp.Data.Repositories
{
    public class ItemsRepository : GenericEFRepository<ItemModel>, IItemsRepository
    {
        public ItemsRepository(DataContext _context) : base(_context)
        {
        }

        /// <summary>
        /// While you can still use ordinary EF methods to interact with the data later if you want, BulkUpload allows you to insert several thousands records at a time
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkUpload(IEnumerable<ItemModel> items)
        {
            await _context.BulkInsertAsync(items.ToList());
        }
    }
}