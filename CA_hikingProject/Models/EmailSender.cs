using Microsoft.AspNetCore.Identity.UI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;



namespace CA_hikingProject.Models
{
    public class EmailSender :IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string myUrl)
        {
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.UseDefaultCredentials = false;
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential("faridaahadli69@gmail.com", "feride20!");
            MailMessage msg = new MailMessage();
            msg.From = new MailAddress("faridaahadli69@gmail.com");
            msg.To.Add(new MailAddress(email));
            msg.IsBodyHtml = true;
         
            msg.Subject = subject;
            msg.Body = myUrl;
            return smtp.SendMailAsync(msg);
        }
    }
}


