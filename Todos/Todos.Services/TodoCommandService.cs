using System;
using System.Threading.Tasks;
using Todos.Core.Abstractions;
using Todos.Core.Exceptions;
using Todos.Core.Models;
using Todos.Data;

namespace Todos.Services
{
    public class TodoCommandService : ITodoCommandService
    {
        private readonly TodosDbContext _context;

        public TodoCommandService(TodosDbContext context)
        {
            _context = context;
        }

        public async Task<Todo> AddAsync(Todo todo)
        {
            var result = await _context.Todos.AddAsync(todo);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public Task<Todo> EditAsync(Todo todo)
        {
            var result = _context.Update(todo);
            return Task.FromResult(result.Entity);
        }

        public async Task<Todo> ChangeDueDateAsync(int todoId, DateTime dueDate)
        {
            var todo = _context.Todos.Find(todoId);
            if (todo is null)
                throw new TodoNotFoundException(todoId);

            todo.DueDate = dueDate;
            await _context.SaveChangesAsync();

            return todo;
        }

        public async Task<Todo> ChangeStartDateAsync(int todoId, DateTime startDate)
        {
            var todo = _context.Todos.Find(todoId);
            if (todo is null)
                throw new TodoNotFoundException(todoId);

            todo.StartDate = startDate;
            await _context.SaveChangesAsync();

            return todo;
        }

        public async Task<Todo> AssignToAsync(int todoId, int userId)
        {
            var todo = _context.Todos.Find(todoId);
            if (todo is null)
                throw new TodoNotFoundException(todoId);

            todo.UserId = userId;
            await _context.SaveChangesAsync();

            return todo;
        }

        public async Task<Todo> SetStatusAsync(int todoId, TodoStatus status)
        {
            var todo = _context.Todos.Find(todoId);
            if (todo is null)
                throw new TodoNotFoundException(todoId);

            todo.Status = status;
            await _context.SaveChangesAsync();

            return todo;
        }
    }
}