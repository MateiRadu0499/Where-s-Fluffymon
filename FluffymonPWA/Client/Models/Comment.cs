using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluffymonPWA.Client.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int IdUser { get; set; }
        public int Likes { get; set; } = 0;
        public int Dislikes { get; set; } = 0;
    }
}
