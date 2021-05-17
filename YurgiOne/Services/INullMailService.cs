namespace YurgiOne.Services
{
    public interface INullMailService
    {
        void SendMessage(string name, string email, string subject, string body);
    }
}