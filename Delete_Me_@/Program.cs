using System;
using System.IO;
using System.Threading.Tasks;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace Delete_Me__
{
    public sealed class Program
    {
        public static void Main()
        {
            Execute().Wait();
        }

        static async Task Execute()
        {
            var apiKey = "";
            var client = new SendGridClient(apiKey);
            //from is email of the user logged in i am using here single user for testing
            var from = new EmailAddress("", "Example User");
            var subject = "the subject Sending with SendGrid is Fun";

            var to = new EmailAddress("", "");
            var plainTextContent = "and easy to do anywhere, even with C#";
            var htmlContent = "<quote>and easy to do anywhere, even with C#</quote>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg);
        }
    }
}



//public string sendEmail(string mail, string subject, string body)
//{
//    try
//    {
//        MailMessage message = new MailMessage();
//        SmtpClient smtp = new SmtpClient();
//        message.From = new MailAddress("example@gmail.com");
//        message.To.Add(new MailAddress(mail));
//        message.Subject = subject;
//        message.IsBodyHtml = true; //to make message body as html  
//        message.Body = body;
//        smtp.Port = 587;
//        smtp.Host = "smtp.gmail.com"; //for gmail host  
//        smtp.EnableSsl = true;
//        smtp.UseDefaultCredentials = false;
//        smtp.Credentials = new NetworkCredential("example@gmail.com", "password");
//        smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
//        smtp.Send(message);
//        return "success";
//    }
//    catch (Exception e)
//    {
//        return e.Message;
//    }
