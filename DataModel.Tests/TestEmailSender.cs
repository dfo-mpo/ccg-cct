using System.Collections.Generic;
using System.Net.Mail;
using System.Threading.Tasks;
using CCG.AspNetCore.Common;

namespace DataModel.Tests
{
    public class TestEmailSender : IEmailSender
    {
        public readonly IList<MailMessage> SentMessages = new List<MailMessage>();
        private readonly string _from;

        public TestEmailSender(string from = "test@dfo-mpo.gc.ca")
        {
            _from = from;
        }

        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            await Task.Run(() =>
            {
                var message = new MailMessage
                {
                    From = new MailAddress(_from),
                    Subject = subject,
                    Body = htmlMessage,
                    IsBodyHtml = true,
                    To = {email}
                };
                SentMessages.Add(message);
            });
        }
    }

 
}
