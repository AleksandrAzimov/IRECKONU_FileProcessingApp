using IRECKONU_FileProcessingApp.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace IRECKONU_FileProcessingApp.Data.Repositories
{
    public class JsonRepository<T> : IJsonRepository<T> where T : class
    {
        public async Task InsertAsync(T obj)
        {
            List<T> list = new List<T>();
            await InsertManyAsync(list);
        }

        public async Task InsertManyAsync(IEnumerable<T> objs)
        {
            string fileName = $"JSON_{DateTime.Now.ToShortDateString()}_{Guid.NewGuid()}.json";

            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
            };

            using (FileStream fs = File.Create(fileName))
            {
                await JsonSerializer.SerializeAsync(fs, objs, options);
            }
        }
    }
}