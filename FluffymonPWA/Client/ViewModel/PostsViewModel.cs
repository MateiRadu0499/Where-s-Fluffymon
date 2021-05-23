using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluffymonPWA.Client.ViewModel
{
    public class PostsViewModel
    { 
        public string Title { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string Reward { get; set; }
        public string Image { get; set; }
    }
}
