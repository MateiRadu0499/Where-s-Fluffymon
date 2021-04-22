using Microsoft.AspNetCore.Mvc;
using FluffymonPWA.Server.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System;

namespace FluffymonPWA.Server.Controllers
{
    [Route("api/v1/post")]
    [ApiController]
    public class PostsController : Controller
    {
        private readonly DataContext _context;
        public PostsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Post>>> GetPosts()
        {
            Console.WriteLine("Posts Get");
            return await _context.Posts.ToListAsync();
        }

        [HttpGet("{id}", Name ="GetPostById")]
        public async Task<ActionResult<Post>> GetPostById(int id)
        {
            var post = await _context.Posts.FindAsync(id);
            if(post == null)
            {
                return NotFound();
            }

            return post;
        }
        [HttpPost]
        public async Task<ActionResult<Post>> MakePost(Post post)
        {
            Console.WriteLine("Posts Post");
            _context.Posts.Add(post);
            await _context.SaveChangesAsync();
            string Status = "Post created successfully.";
            return Ok(Status);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePost(int id)
        {
            var post = await _context.Posts.FindAsync(id);
            if(post == null)
            {
                return NotFound();
            }

            _context.Posts.Remove(post);
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
