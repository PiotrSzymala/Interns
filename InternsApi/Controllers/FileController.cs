using InternsApi.Models.DTO;
using InternsApi.Models.Enum;
using InternsApi.Services.Download;
using InternsApi.Services.Parsing;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InternsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileController : ControllerBase
    {
        private readonly IDownloadService _fileService;
        private readonly IParseService _parseService;

        public FileController(IDownloadService fileService, IParseService parseService)
        {
            _fileService = fileService;
            _parseService = parseService;
        }

        [HttpGet]
        public async Task<ActionResult<FileResponseDto>> GetFile([FromQuery] TypeEnum type)
        {
            var result = await _fileService.GetFileAsync(type.ToString().ToLower());

            if (string.IsNullOrEmpty(result.Response))
                return UnprocessableEntity(result);

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult> ProcessData([FromBody] FileResponseDto dto)
        {
            await _parseService.ParseFile(dto);
            return Ok(dto);
        }
    }
}
