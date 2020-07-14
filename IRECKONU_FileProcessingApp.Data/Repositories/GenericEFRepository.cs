using IRECKONU_FileProcessingApp.Data.Contexts;
using IRECKONU_FileProcessingApp.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRECKONU_FileProcessingApp.Data.Repositories
{
    public class GenericEFRepository<T> : IGenericEFRepository<T> where T : class
    {
        public DbSet<T> table = null;
        public DataContext _context;

        public GenericEFRepository(DataContext _context)
        {
            this._context = _context;
            table = _context.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await table.ToListAsync();
        }

        public async Task<T> GetByIdAsync(object id)
        {
            return await table.FindAsync(id);
        }

        public async Task InsertAsync(T obj)
        {
            await table.AddAsync(obj);
        }

        public void Update(T obj)
        {
            table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }

        public void Delete(object id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public async Task InsertManyAsync(IEnumerable<T> objs)
        {
            await table.AddRangeAsync(objs);
        }
    }
}