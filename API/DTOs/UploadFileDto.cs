using Microsoft.AspNetCore.Http;

namespace API.DTOs
{
    public class UploadFileDto
    {
        public IFormFile File { get; set; }
    }
}