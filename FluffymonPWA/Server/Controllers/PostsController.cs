using Microsoft.AspNetCore.Mvc;
using FluffymonPWA.Server.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System;

namespace FluffymonPWA.Server.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class PostsController : Controller
    {
        private readonly DataContext _context;
        public PostsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("all")]
        public async Task<ActionResult<IEnumerable<Post>>> GetPosts()
        {
            Console.WriteLine("Posts Get");
            return await _context.Posts.ToListAsync();
        }

        [HttpPost("makepost")]
        public async Task<ActionResult<Post>> MakePost(Post post)
        {
            Console.WriteLine("Posts Post");
            _context.Posts.Add(post);
            await _context.SaveChangesAsync();
            string Status = "Post created successfully.";
            return Ok(Status);
        }
    }
}
