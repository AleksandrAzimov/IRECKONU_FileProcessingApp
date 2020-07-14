using IRECKONU_FileProcessingApp.Domain.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace IRECKONU_FileProcessingApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilesController : ControllerBase
    {
        private readonly IFileProcessingService _fileProcessingService;
        private readonly ILogger<FilesController> _logger;

        public FilesController(IFileProcessingService fileProcessingService, ILogger<FilesController> logger)
        {
            _fileProcessingService = fileProcessingService;
            _logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult> Upload(IFormFile file)
        {
            if (file.Length > 0)
            {
                using (var memoryStream = new MemoryStream())
                {
                    file.CopyTo(memoryStream);
                    var bytes = memoryStream.ToArray();
                    await _fileProcessingService.ProcessFile(bytes);
                }
                return Ok();
            }

            return BadRequest();
        }
    }
}