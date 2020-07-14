using CsvHelper;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace IRECKONU_FileProcessingApp.Domain.Utils
{
    public class CsvFileReader : ICsvFileReader
    {
        public IEnumerable<T> ReadFromCSV<T>(byte[] file)
        {
            using (var stream = new MemoryStream(file))
            {
                using (var reader = new StreamReader(stream))
                {
                    using (var csvReader = new CsvReader(reader, CultureInfo.InvariantCulture))
                    {
                        csvReader.Configuration.HeaderValidated = null;
                        csvReader.Configuration.MissingFieldFound = null;
                        var records = csvReader.GetRecords<T>().ToList();
                        return records;
                    }
                }
            }
        }
    }
}