using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Todos.Data;
using Todos.Services;
using Xunit;
using Xunit.Abstractions;
using Microsoft.EntityFrameworkCore.InMemory;
using Todos.Core.Exceptions;
using Todos.Core.Models;

#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously

namespace Todos.Tests
{
    public class UserServiceShould
    {
        public ITestOutputHelper Output { get; }
        private UserService _userService;

        public UserServiceShould(ITestOutputHelper output)
        {
            Output = output;
        }

        [Fact]
        public async Task RegisterUser()
        {
            var options = new DbContextOptionsBuilder().UseInMemoryDatabase("RegisterUserDb").Options;
            var dbContext = new TodosDbContext(options);
            _userService = new UserService(dbContext);

            var user = await _userService.RegisterAsync(new User
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
            var options = new DbContextOptionsBuilder().UseInMemoryDatabase("ThrowUserAlreadyRegisteredExceptionDb").Options;
            var dbContext = new TodosDbContext(options);
            _userService = new UserService(dbContext);

            var user = await _userService.RegisterAsync(new User
            {
                Email = "Test@gmail.com",
                Password = "Test123",
                Name = "First name"
            });

            Assert.Equal(1, user.Id);

            await Assert.ThrowsAsync<UserAlreadyRegisteredException>(() => _userService.RegisterAsync(new User
            {
                Email = "Test@gmail.com",
                Password = "Test123",
                Name = "First name"
            }));
        }

        [Fact]
        public async Task LoginUserWhenCorrectUserNameAndPassword()
        {
            var options = new DbContextOptionsBuilder().UseInMemoryDatabase("LoginUserWhenCorrectUserNameAndPasswordDb").Options;
            var dbContext = new TodosDbContext(options);
            _userService = new UserService(dbContext);

            var user = await _userService.RegisterAsync(new User
            {
                Email = "Test@gmail.com",
                Password = "Test123",
                Name = "First name"
            });

            Assert.Equal(1, user.Id);

            var loggedIn = await _userService.LoginAsync(user);
            Assert.True(loggedIn);

            loggedIn = await _userService.LoginAsync(user.Email, user.Password);
            Assert.True(loggedIn);
        }

        [Fact]
        public async Task NotLoginUserWhenIncorrectUserNameAndPassword()
        {
            var options = new DbContextOptionsBuilder().UseInMemoryDatabase("NotLoginUserWhenIncorrectUserNameAndPassword").Options;
            var dbContext = new TodosDbContext(options);
            _userService = new UserService(dbContext);

            const string wrongUserName = "Wrong User Name";
            const string wrongPassword = "Wrong Password";

            var user = await _userService.RegisterAsync(new User
            {
                Email = "Test@gmail.com",
                Password = "Test123",
                Name = "First name"
            });

            Assert.Equal(1, user.Id);

            var loggedIn = await _userService.LoginAsync(new User
            {
                Email = wrongUserName,
                Password = wrongPassword
            });
            Assert.False(loggedIn);

            loggedIn = await _userService.LoginAsync(wrongUserName, wrongPassword);
            Assert.False(loggedIn);
        }
    }
}

#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously