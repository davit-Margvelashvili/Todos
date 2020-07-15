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

        public async Task<Todo> GetByIdAsync(int todoId) => await _context.Todos.FindAsync(todoId);

        public Task<IEnumerable<Todo>> GetByUserAsync(int userId)
        {
            IEnumerable<Todo> todos = _context.Todos.Where(todo => todo.UserId == userId).ToList();
            return Task.FromResult(todos);
        }

        public Task<IEnumerable<Todo>> QueryAsync(Func<Todo, bool> predicate)
        {
            IEnumerable<Todo> todos = _context.Todos.Where(predicate).ToList();
            return Task.FromResult(todos);
        }
    }
}