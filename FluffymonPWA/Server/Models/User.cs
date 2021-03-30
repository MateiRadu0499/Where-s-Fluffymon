using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace FluffymonPWA.Server.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool IsDeleted { get; set; }
        public IEnumerable<Post> Posts { get; set; }

        public void MarkAsDeleted()
        {
            IsDeleted = true;
        }

        public static implicit operator User(ActionResult<IEnumerable<User>> v)
        {
            throw new NotImplementedException();
        }
    }
}
