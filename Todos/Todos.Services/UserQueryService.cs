using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todos.Core.Abstractions;
using Todos.Core.Models;
using Todos.Data;

namespace Todos.Services
{
    public class UserQueryService : IUserQueryService
    {
        private readonly TodosDbContext _context;

        public UserQueryService(TodosDbContext context)
        {
            _context = context;
        }

        public Task<List<User>> GetAllAsync() =>
            Task.FromResult(_context.Users.ToList());

        public async Task<User> GetByIdAsync(int id) =>
            await _context.Users.FindAsync(id);
    }
}