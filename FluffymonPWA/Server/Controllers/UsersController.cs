using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FluffymonPWA.Server.Models;
using System;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;

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

        static string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
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
                            mail.Body += "username:" + user.Username + "<br>";
                            mail.Body += "password:" + user.Password  + " ";
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
