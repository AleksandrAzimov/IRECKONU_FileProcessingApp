using System;
using System.Collections.Generic;
using System.Text;

namespace IRECKONU_FileProcessingApp.Domain.Utils
{
    public interface ICsvFileReader
    {
        IEnumerable<T> ReadFromCSV<T>(byte[] file);
    }
}