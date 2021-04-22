using System;
using System.Collections.Generic;

namespace FluffymonPWA.Server.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public IEnumerable<Comment> Comments { get; set; }
        public string Reward { get; set; }
        
    }
}
