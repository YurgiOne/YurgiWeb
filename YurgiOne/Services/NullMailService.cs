using Microsoft.Extensions.Logging;

namespace YurgiOne.Services
{
    public class NullMailService : INullMailService
    {
        private ILogger<NullMailService> _logger;

        public NullMailService(ILogger<NullMailService> logger)
        {
            _logger = logger;
        }
        public void SendMessage(string to, string subject, string body)
        {
            //Log the message
            _logger.LogInformation($"TO:{to} \n subject: {subject} \n body: {body}");
        }
    }
}
