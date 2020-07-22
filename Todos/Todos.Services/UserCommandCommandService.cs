using System;
using System.Globalization;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient.Server;
using Microsoft.EntityFrameworkCore;
using Todos.Core.Abstractions;
using Todos.Core.Exceptions;
using Todos.Core.Models;
using Todos.Data;

namespace Todos.Services
{
    public class UserCommandCommandService : IUserCommandService
    {
        private readonly TodosDbContext _context;

        public UserCommandCommandService(TodosDbContext context)
        {
            _context = context;
        }

        public async Task<User> RegisterAsync(User user)
        {
            user.Email = user.Email.ToLowerInvariant();
            var userIsAlreadyRegistered = await _context.Users.AnyAsync(u => u.Email == user.Email);

            if (userIsAlreadyRegistered)
                throw new UserAlreadyRegisteredException(user);

            var result = await _context.Users.AddAsync(user);

            await _context.SaveChangesAsync();

            return result.Entity;
        }

        public Task<User> LoginAsync(User user)
        {
            return LoginAsync(user.Email, user.Password);
        }

        public Task<User> LoginAsync(string userName, string password)
        {
            userName = userName.ToLowerInvariant();
            return _context.Users.FirstOrDefaultAsync(user =>
                user.Email == userName
                && user.Password == password);
        }
    }
}