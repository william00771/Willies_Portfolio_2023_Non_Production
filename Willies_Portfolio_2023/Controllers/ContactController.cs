using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Net;
using System.Net.Mail;
using Willies_Portfolio_2023.Models;

namespace Willies_Portfolio_2023.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PostEmail(ContactFormVM contactformvm)
        {
            if (!ModelState.IsValid)
            {
                return View("Index");
            }
            var name = contactformvm.FullName;
            var mail = contactformvm.Email;
            var message = contactformvm.Message;

            try
            {
                SendMail(name, mail, message);
                return Redirect(Url.Action("PostSuccess", "Contact") + "#Sent");
            }
            catch (Exception)
            {
                return View("Error");
                throw;
            }
            
        }

        public bool SendMail(string name, string email, string message1)
        {
            MailMessage message = new MailMessage();    
            SmtpClient smtpClient = new SmtpClient();
            message.From = new MailAddress("william.f.lindberg@hotmail.com");
            message.To.Add("william.f.lindberg@hotmail.com");
            message.Subject = "From: WilliamL.";
            message.IsBodyHtml = true;
            message.Body = "<h1> Name:" + name + "</h1> Email: " + email + "</p>" + "</p> Message:" + message1 + "</p>";


            smtpClient.Port = 587;//smtpproviderport;
            smtpClient.Host = "smtp.office365.com";
            smtpClient.EnableSsl= true;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential("personal mail", "personal mail password");
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.Send(message);
            return true;
        }

        public IActionResult PostSuccess()
        {
            return View();
        }


        
    }
}
