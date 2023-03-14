using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace administradorCompartidas
{
    public class Correo
    {
        public static bool enviarCorreo(string email, string subject, string body)
        {
            try
            {
                MailMessage correo = new MailMessage();
                correo.From = new MailAddress("correostest@outlook.com", "Cambio de contraseña");
                correo.To.Add(email);
                correo.Subject = subject;
                correo.Body = body;
                correo.IsBodyHtml = true;
                correo.Priority = MailPriority.Normal;

                SmtpClient smtpc = new SmtpClient();
                smtpc.Host = "smtp.office365.com";
                smtpc.Port = 25;
                smtpc.Credentials = new NetworkCredential("correostest@outlook.com", "M23cH8f23");
                smtpc.EnableSsl = true;
                smtpc.Send(correo);

                return true;
            }
            catch (Exception oEx)
            {
                return false;
            }
        }
    }
}
