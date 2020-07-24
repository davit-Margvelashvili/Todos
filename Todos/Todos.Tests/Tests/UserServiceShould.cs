using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Todos.Core.Exceptions;
using Todos.Core.Models;
using Todos.Data;
using Todos.Services;
using Xunit;
using Xunit.Abstractions;

#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously

namespace Todos.Tests.Tests
{
    public class UserServiceShould
    {
        public ITestOutputHelper Output { get; }

        public UserServiceShould(ITestOutputHelper output)
        {
            Output = output;
        }

        [Fact]
        public async Task RegisterUser()
        {
            var userService = CreateUserService(nameof(RegisterUser));

            var user = await userService.RegisterAsync(new User
            {
                Email = "Test@gmail.com",
                Password = "Test123",
                Name = "First name"
            });

            Assert.Equal(1, user.Id);
            Assert.Equal("Test@gmail.com", user.Email);
            Assert.Equal("Test123", user.Password);
            Assert.Equal("First name", user.Name);
        }

        [Fact]
        public async Task ThrowUserAlreadyRegisteredException()
        {
            var userService = CreateUserService(nameof(ThrowUserAlreadyRegisteredException));

            var user = await userService.RegisterAsync(new User
            {
                Email = "Test@gmail.com",
                Password = "Test123",
                Name = "First name"
            });

            Assert.Equal(1, user.Id);

            await Assert.ThrowsAsync<UserAlreadyRegisteredException>(() => userService.RegisterAsync(new User
            {
                Email = "Test@gmail.com",
                Password = "Test123",
                Name = "First name"
            }));
        }

        [Fact]
        public async Task LoginUserWhenCorrectUserNameAndPassword()
        {
            var userService = CreateUserService(nameof(LoginUserWhenCorrectUserNameAndPassword));

            var user = await userService.RegisterAsync(new User
            {
                Email = "Test@gmail.com",
                Password = "Test123",
                Name = "First name"
            });

            Assert.Equal(1, user.Id);

            var loggedIn = await userService.LoginAsync(user);
            Assert.NotNull(loggedIn);

            loggedIn = await userService.LoginAsync(user.Email, user.Password);
            Assert.NotNull(loggedIn);
        }

        [Fact]
        public async Task NotLoginUserWhenIncorrectUserNameAndPassword()
        {
            var userService = CreateUserService(nameof(NotLoginUserWhenIncorrectUserNameAndPassword));

            const string wrongUserName = "Wrong User Name";
            const string wrongPassword = "Wrong Password";

            var user = await userService.RegisterAsync(new User
            {
                Email = "Test@gmail.com",
                Password = "Test123",
                Name = "First name"
            });

            Assert.Equal(1, user.Id);

            var loggedIn = await userService.LoginAsync(new User
            {
                Email = wrongUserName,
                Password = wrongPassword
            });
            Assert.Null(loggedIn);

            loggedIn = await userService.LoginAsync(wrongUserName, wrongPassword);
            Assert.Null(loggedIn);
        }

        private static UserCommandCommandService CreateUserService(string databaseName)
        {
            var options = new DbContextOptionsBuilder().UseInMemoryDatabase(databaseName)
                .Options;
            var dbContext = new TodosDbContext(options);
            var userService = new UserCommandCommandService(dbContext);
            return userService;
        }
    }
}

#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously