using System;
using Xunit;
using FluffymonPWA.Server.Controllers;
using FluffymonPWA.Server.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace FluffymonPWA.UnitTest
{
    public class UsersControllerTests
    {
        private readonly IServiceProvider serviceProvider;

        public UsersControllerTests()
        {
            var services = new ServiceCollection();

            string _databaseName = "Users";

            string randomNumber = (new Random().Next()).ToString();

            _databaseName += randomNumber;

            services.AddEntityFrameworkInMemoryDatabase()
                .AddDbContext<DataContext>(options => options.UseInMemoryDatabase(databaseName: _databaseName));

            serviceProvider = services.BuildServiceProvider();

        }

        private User user1 = new User
        {
            Id = 100,
            Username = "usertest1",
            FirstName = "Test",
            LastName = "Testy",
            PhoneNumber = "07124717561",
            Password = "asd123asd",
            Email = "mateiradu71@gmail.com",
            Posts = null
        };

        [Fact]
        public void ShouldLoginUser()
        {
            var context = serviceProvider.GetRequiredService<DataContext>();

            var controller = new LoginController(context);

            context.Users.Add(user1);
            context.SaveChanges();

            var result = controller.LoginUser(user1);

            Assert.NotNull(result);
        }

        [Fact]
        public void ShouldRegisterUser()
        {
            var context = serviceProvider.GetRequiredService<DataContext>();

            var controller = new RegisterController(context);
            var result = controller.RegisterUser(user1);

            Assert.NotNull(result);
        }

        [Fact]
        public void EmailUser()
        {
            var context = serviceProvider.GetRequiredService<DataContext>();

            var controller = new UsersController(context);

            context.Users.Add(user1);
            context.SaveChanges();

            var result = controller.EmailUser(user1.Email);

            Assert.True(result == 1);
        }

        [Fact]
        public void GetUserById_ShouldReturnUserById()
        {
            var context = serviceProvider.GetRequiredService<DataContext>();
            var controller = new UsersController(context);
            context.Users.Add(user1);
            var user = controller.GetUser(100).Result.Value;
            Assert.Equal(user, user1);
        }


    }
}
