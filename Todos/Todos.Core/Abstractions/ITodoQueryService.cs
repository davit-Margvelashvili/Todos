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

        Task<IEnumerable<Todo>> GetByUserAsync(int userId);

        Task<IEnumerable<Todo>> QueryAsync(Func<Todo, bool> where);
    }
}