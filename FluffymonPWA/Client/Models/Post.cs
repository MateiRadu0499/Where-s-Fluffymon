using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluffymonPWA.Client.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public float Latitude { get; set; }
        public float Longitute { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public IEnumerable<Comment> Comments { get; set; }
        public string Reward { get; set; }

    }
}
