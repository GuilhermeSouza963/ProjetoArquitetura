using Microsoft.AspNetCore.Mvc;
using Util;
using System.Net;
using System.Net.Mail;

namespace Arquitetura.WebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //EnviarEmail();

            return View();
        }
        public void EnviarEmail()
        {
            var email = new EmailUtil("smtp", new NetworkCredential("user", "senha"), 587);

            email.Enviador = new MailAddress("emailenviador@email.com");
            email.Destinatario = "emaildestinatario@email.com";
            email.Titulo = "Seja Bem Vindo";
            email.Corpo = "Corpo Email";
            email.Enviar();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";
            return View();
        }



    }
}
