using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Todos.Core.Models;

namespace Todos.Core.Abstractions
{
    public interface ITodoQueryService
    {
        Task<Todo> GetByIdAsync(int todoId);

        Task<List<Todo>> GetByUserAsync(int userId);

        Task<List<Todo>> GetAllAsync();

        Task<List<Todo>> QueryAsync(Func<Todo, bool> where);
    }
}