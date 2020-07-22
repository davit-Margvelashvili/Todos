using System;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient.Server;
using Microsoft.EntityFrameworkCore;
using Todos.Core.Abstractions;
using Todos.Core.Exceptions;
using Todos.Core.Models;
using Todos.Data;

namespace Todos.Services
{
    public class UserCommandService : IUserService
    {
        private readonly TodosDbContext _context;

        public UserCommandService(TodosDbContext context)
        {
            _context = context;
        }

        public async Task<User> RegisterAsync(User user)
        {
            var userIsAlreadyRegistered = await _context.Users.AnyAsync(u =>
                    u.Email.Equals(user.Email, StringComparison.InvariantCultureIgnoreCase));

            if (userIsAlreadyRegistered)
                throw new UserAlreadyRegisteredException(user);

            var result = await _context.Users.AddAsync(user);

            await _context.SaveChangesAsync();

            return result.Entity;
        }

        public Task<bool> LoginAsync(User user)
        {
            return LoginAsync(user.Email, user.Password);
        }

        public Task<bool> LoginAsync(string userName, string password) =>
            _context.Users.AnyAsync(user =>
                user.Email.Equals(userName, StringComparison.OrdinalIgnoreCase)
                && user.Password.Equals(password, StringComparison.InvariantCulture));
    }
}