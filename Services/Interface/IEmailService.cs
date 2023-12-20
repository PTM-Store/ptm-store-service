using ptm_store_service.Data;

namespace ptm_store_service.Services.Interface
{
    public interface IEmailService
    {
        void SendEmail(string toAddress, string subject, string body);
        void SendConfirmationEmail(Users users, string token);
    }
}
