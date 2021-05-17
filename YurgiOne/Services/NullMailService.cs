using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;

namespace YurgiOne.Services
{
    public class NullMailService : INullMailService
    {
        private readonly IWebHostEnvironment _env;
        private readonly ILogger<NullMailService> _logger;

        public NullMailService(ILogger<NullMailService> logger, IWebHostEnvironment env)
        {
            _logger = logger;
            _env = env;
        }


        public void SendMessage(string name, string email, string subject, string body)
        {
            //TODO: implement send message
        }
    }
}