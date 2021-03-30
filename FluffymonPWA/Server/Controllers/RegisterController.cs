using Microsoft.AspNetCore.Mvc;
using System.Linq;
using FluffymonPWA.Server.Models;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text;

namespace FluffymonPWA.Server.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class RegisterController : Controller
    {
        private readonly DataContext _context;

        public RegisterController(DataContext context)
        {
            _context = context;
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

        [HttpPost]
        public async Task<ActionResult<User>> RegisterUser(User userRegister)
        {
            var display = _context.Users.Where(u => u.Username == userRegister.Username || u.Email == userRegister.Email).FirstOrDefault();

            if (display != null)
            {
                string Status = "Username or email already taken.";
                return BadRequest(Status);
            }
            else
            {
                userRegister.Password = ComputeSha256Hash(userRegister.Password);
                _context.Users.Add(userRegister);
                //await _context.SaveChangesAsync();
                string Status = "Registered successfully.";
                return Ok();
            }
        }
    }
}
