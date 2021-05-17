using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FluffymonPWA.Server.Models;
using System;
using System.Net.Mail;

namespace FluffymonPWA.Server.Controllers
{
    [Route("api/v1/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;

        public UsersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            var user = await _context.Users.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }
            Console.WriteLine(user);

            return user;
        }

        [HttpPost("sendemail")]
        public int EmailUser([FromBody] string emailTo)
        {

            List<User> users = _context.Users.ToList();

            foreach (User user in users)
            {
                if (user.Email == emailTo)
                {
                    try {
                        using (MailMessage mail = new MailMessage())
                        {
                            mail.From = new MailAddress("fluffymonnet@gmail.com");
                            mail.To.Add(emailTo);
                            mail.Subject = "[Fluffymon] Recover your username and password!";
                            mail.Body = "<h1>Here are your credentials!</h1>";
                            mail.Body += "username:" + user.Username;
                            mail.Body += "password:" + user.Password;
                            mail.IsBodyHtml = true;

                            using SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                            smtp.Credentials = new System.Net.NetworkCredential("fluffymonnet@gmail.com", "Admin123Admin");
                            smtp.EnableSsl = true;
                            smtp.Send(mail);
                            return 1;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                        return -1;
                    }
                }
            }
            return -1;

        }
    }
}
