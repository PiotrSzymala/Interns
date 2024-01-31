using InternsApi.Models;
using InternsApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InternsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileController : ControllerBase
    {
        private readonly IFileService _fileService;

        public FileController(IFileService fileService)
        {
            _fileService = fileService;
        }

        [HttpGet]
        public async Task<ActionResult<FileResponseDto>> GetFile([FromQuery] TypeEnum type)
        {
            var result = await _fileService.GetFileAsync(type.ToString().ToLower());

            if (string.IsNullOrEmpty(result.Response))
                return UnprocessableEntity(result);

            return Ok(result);
        }
    }
}
