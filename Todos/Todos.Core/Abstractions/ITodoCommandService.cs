using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Todos.Core.Models;

namespace Todos.Core.Abstractions
{
    public interface ITodoCommandService
    {
        Task<Todo> AddAsync(Todo todo);

        Task<Todo> EditAsync(Todo todo);

        Task<Todo> ChangeDueDateAsync(int todoId, DateTime dueDate);

        Task<Todo> ChangeStartDateAsync(int todoId, DateTime startDate);

        Task<Todo> AssignToAsync(int todoId, int userId);

        Task<Todo> SetStatusAsync(int todoId, TodoStatus status);
    }
}