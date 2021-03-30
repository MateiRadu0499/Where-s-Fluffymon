﻿using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using FluffymonPWA.Server.Models;


namespace FluffymonPWA.Server.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class LoginController : Controller
    {
        private readonly DataContext _context;
        public LoginController(DataContext context)
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
        public ActionResult LoginUser(User userLogin)
        {
            string hashedPass = ComputeSha256Hash(userLogin.Password);
            var display = _context.Users.Where(u => (u.Username == userLogin.Username && u.Password == hashedPass && u.IsDeleted == false)).FirstOrDefault();
            if (display != null)
            {
                string Status = "Authenticated succesfully.";
                return Ok(display.Id);
            }
            else
            {
                string Status = "Incorrect username or password.";
                return BadRequest(Status);
            }
        }
    }
}