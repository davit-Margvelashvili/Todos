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
    public class TodoQueryService : ITodoQueryService
    {
        private readonly TodosDbContext _context;

        public TodoQueryService(TodosDbContext context)
        {
            _context = context;
        }

        public async Task<Todo> GetByIdAsync(int todoId) =>
            await _context.Todos.FindAsync(todoId);

        public Task<List<Todo>> GetByUserAsync(int userId) =>
            Task.FromResult(_context.Todos.Where(todo => todo.UserId == userId).ToList());

        public Task<List<Todo>> GetAllAsync() =>
            Task.FromResult(_context.Todos.ToList());

        public Task<List<Todo>> QueryAsync(Func<Todo, bool> predicate) =>
            Task.FromResult(_context.Todos.Where(predicate).ToList());
    }
}