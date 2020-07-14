using IRECKONU_FileProcessingApp.Data.Models;
using IRECKONU_FileProcessingApp.Data.Repositories.Interfaces;
using IRECKONU_FileProcessingApp.Domain.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRECKONU_FileProcessingApp.Domain.Services
{
    public class FileProcessingService : IFileProcessingService
    {
        private readonly ICsvFileReader _csvFileReader;
        private readonly IItemsRepository _itemsRepository;
        private readonly IJsonRepository<ItemModel> _jsonRepository;

        public FileProcessingService(ICsvFileReader csvFileReader, IItemsRepository itemsRepository, IJsonRepository<ItemModel> jsonRepository)
        {
            _csvFileReader = csvFileReader;
            _itemsRepository = itemsRepository;
            _jsonRepository = jsonRepository;
        }

        public async Task ProcessFile(byte[] file)
        {
            var records = _csvFileReader.ReadFromCSV<ItemModel>(file);
            if (records.Any())
            {
                await _itemsRepository.BulkUpload(records);
                await _jsonRepository.InsertManyAsync(records);
            }
        }
    }
}