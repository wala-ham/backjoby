using Microsoft.AspNetCore.Http;

namespace Naxxum.JobyHunter.Authentication.Application.User.DTOS.Email
{
    public class EmailRequest
    {
        public string ToEmail { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public List<IFormFile> Attachments { get; set; }
    }
}