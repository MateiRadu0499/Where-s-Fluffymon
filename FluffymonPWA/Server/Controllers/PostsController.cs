using Microsoft.AspNetCore.Mvc;
using FluffymonPWA.Server.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

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
        public async Task<ActionResult<IEnumerable<Post>>> GetAllPosts()
        {
            return await _context.Posts.ToListAsync();
        }

        //[HttpPost]
    }
}
