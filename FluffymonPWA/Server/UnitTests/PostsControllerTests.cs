using System;
using System.Linq;
using FluffymonPWA.Server.Controllers;
using FluffymonPWA.Server.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace UnitTests
{
    public class PostsControllerTests
    {
        private readonly IServiceProvider serviceProvider;
        public PostsControllerTests()
        {
            var services = new ServiceCollection();
            string _databaseName = "Poststest";
            services.AddEntityFrameworkInMemoryDatabase().AddDbContext<DataContext>(options => options.UseInMemoryDatabase(databaseName: _databaseName));
            serviceProvider = services.BuildServiceProvider();
        }

        [Fact]
        public void GetPosts_ShouldReturnAllPosts()
        {
            var context = serviceProvider.GetRequiredService<DataContext>();
            var controller = new PostsController(context);

            Post post1 = new Post {
                Id = 1,
                Title = "Dog1",
                Latitude = 0,
                Longitude = 0,
                Description = "Lorem ipsum1",
                Date = DateTime.Now,
                Comments = null,
                Reward = "20 USD"
            };
            Post post2 = new Post {
                Id = 2,
                Title = "Dog2",
                Latitude = 0,
                Longitude = 0,
                Description = "Lorem ipsum2",
                Date = DateTime.Now,
                Comments = null,
                Reward = "20 USD"
            };
            Post post3 = new Post
            {
                Id = 3,
                Title = "Dog3",
                Latitude = 0,
                Longitude = 0,
                Description = "Lorem ipsum3",
                Date = DateTime.Now,
                Comments = null,
                Reward = "20 USD"
            };

            context.Posts.Add(post1);
            context.Posts.Add(post2);
            context.Posts.Add(post3);
            context.SaveChanges();

            var posts = controller.GetPosts().Result.Value.ToList();
            Assert.Equal(post1, posts[0]);
            Assert.Equal(post2, posts[1]);
            Assert.Equal(post3, posts[2]);
        }

        [Fact]
        public void GetByIdPost_ShouldReturnPostById()
        {
            var context = serviceProvider.GetRequiredService<DataContext>();
            var controller = new PostsController(context);
            Post post1 = new Post
            {
                Id = 1,
                Title = "Dog1",
                Latitude = 0,
                Longitude = 0,
                Description = "Lorem ipsum1",
                Date = DateTime.Now,
                Comments = null,
                Reward = "20 USD"
            };
            context.Posts.Add(post1);
            var post = controller.GetPostById(1).Result.Value;

            Assert.Equal(post1, post);
        }

        [Fact]
        public void CreatePostAsync()
        {
            var context = serviceProvider.GetRequiredService<DataContext>();
            var controller = new PostsController(context);
            Post post1 = new Post
            {
                Id = 1,
                Title = "Dog1",
                Latitude = 0,
                Longitude = 0,
                Description = "Lorem ipsum1",
                Date = DateTime.Now,
                Comments = null,
                Reward = "20 USD"
            };
            controller.MakePost(post1);
            var createdPost = controller.GetPostById(post1.Id).Result.Value;

            Assert.Equal(post1, createdPost);
        }

        [Fact]
        public void DeletePost()
        {
            var context = serviceProvider.GetRequiredService<DataContext>();
            var controller = new PostsController(context);
            Post post1 = new Post
            {
                Id = 1,
                Title = "Dog1",
                Latitude = 0,
                Longitude = 0,
                Description = "Lorem ipsum1",
                Date = DateTime.Now,
                Comments = null,
                Reward = "20 USD"
            };
            context.Posts.Add(post1);
            context.SaveChanges();
            controller.DeletePost(1);
            var post = controller.GetPostById(1).Result.Value;

            Assert.Null(post);
        }
    }
}
