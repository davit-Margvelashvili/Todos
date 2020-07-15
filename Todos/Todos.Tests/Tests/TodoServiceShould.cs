using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Todos.Core.Abstractions;
using Todos.Core.Models;
using Todos.Core.Utils;
using Todos.Data;
using Todos.Services;
using Todos.Tests.Infrastructure;
using Xunit;
using Xunit.Abstractions;

#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously

namespace Todos.Tests.Tests
{
    public class TodoServiceShould
    {
        public ITestOutputHelper Output { get; }
        public IDateTimeProvider DateTimeProvider { get; }

        public TodoServiceShould(ITestOutputHelper output)
        {
            Output = output;

            DateTimeProvider = new FakeDateTimeProvider();
        }

        [Fact]
        public async Task AddTodo()
        {
            var service = CreateTodoService(nameof(AddTodo));

            var todo = new Todo
            {
                Title = "Todo 1",
                Description = "New Todo",
                StartDate = DateTimeProvider.Now,
                DueDate = DateTimeProvider.Now.AddDays(2),
                Status = TodoStatus.New,
                Priority = TodoPriority.Important,
            };

            var result = await service.AddAsync(todo);

            Assert.Equal(todo.DeepCopy(), result, TodoEqualityComparer.Default);
        }

        [Fact]
        public async Task EditTodo()
        {
            var service = CreateTodoService(nameof(EditTodo));

            var todo = new Todo
            {
                Title = "Todo 1",
                Description = "New Todo",
                StartDate = DateTimeProvider.Now,
                DueDate = DateTimeProvider.Now.AddDays(2),
                Status = TodoStatus.New,
                Priority = TodoPriority.Important,
            };

            await service.AddAsync(todo);

            todo.Title = "Modified Todo 1";
            todo.Description = "Todo was modified";

            var result = await service.EditAsync(todo);

            Assert.Equal(todo.DeepCopy(), result, TodoEqualityComparer.Default);
        }

        [Fact]
        public async Task ChangeDueDate()
        {
            var service = CreateTodoService(nameof(ChangeDueDate));

            await service.AddAsync(new Todo
            {
                Title = "Todo 1",
                Description = "New Todo",
                StartDate = DateTimeProvider.Now,
                DueDate = DateTimeProvider.Now.AddDays(2),
                Status = TodoStatus.New,
                Priority = TodoPriority.Important,
            });

            var newDueDate = DateTimeProvider.Now.AddDays(4);
            var result = await service.ChangeDueDateAsync(1, newDueDate);

            Assert.Equal(newDueDate, result.DueDate);
        }

        [Fact]
        public async Task ChangeStartDate()
        {
            var service = CreateTodoService(nameof(ChangeStartDate));

            await service.AddAsync(new Todo
            {
                Title = "Todo 1",
                Description = "New Todo",
                StartDate = DateTimeProvider.Now,
                DueDate = DateTimeProvider.Now.AddDays(2),
                Status = TodoStatus.New,
                Priority = TodoPriority.Important,
            });

            var newStartDate = DateTimeProvider.Now.AddDays(4);
            var result = await service.ChangeStartDateAsync(1, newStartDate);

            Assert.Equal(newStartDate, result.StartDate);
        }

        [Fact]
        public async Task SetStatus()
        {
            var service = CreateTodoService(nameof(SetStatus));

            await service.AddAsync(new Todo
            {
                Title = "Todo 1",
                Description = "New Todo",
                StartDate = DateTimeProvider.Now,
                DueDate = DateTimeProvider.Now.AddDays(2),
                Status = TodoStatus.New,
                Priority = TodoPriority.Important,
            });

            var result = await service.SetStatusAsync(1, TodoStatus.Doing);

            Assert.Equal(TodoStatus.Doing, result.Status);
        }

        [Fact]
        public async Task AssignToUser()
        {
            var expectedUser = new User
            {
                Id = 1,
                Email = "User1@mail.com",
                Name = "Joe Black",
                Password = "asd123"
            };

            var service = CreateTodoService(nameof(AssignToUser));

            await service.AddAsync(new Todo
            {
                Title = "Todo 1",
                Description = "New Todo",
                StartDate = DateTimeProvider.Now,
                DueDate = DateTimeProvider.Now.AddDays(2),
                Status = TodoStatus.New,
                Priority = TodoPriority.Important,
            });

            var result = await service.AssignToAsync(1, 1);

            Assert.Equal(1, result.UserId);

            Assert.Equal(expectedUser, result.AssignedTo, UserEqualityComparer.Default);
        }

        private static TodoCommandService CreateTodoService(string databaseName)
        {
            var options = new DbContextOptionsBuilder().UseInMemoryDatabase(databaseName).Options;
            var dbContext = new TodosDbContext(options);
            dbContext.Users.AddRange(
                new User { Id = 1, Email = "User1@mail.com", Name = "Joe Black", Password = "asd123" },
                new User { Id = 2, Email = "User2@mail.com", Name = "John Smith", Password = "1234" });

            return new TodoCommandService(dbContext);
        }
    }
}

#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously