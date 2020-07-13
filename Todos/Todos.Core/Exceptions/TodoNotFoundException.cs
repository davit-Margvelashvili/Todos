#pragma warning disable RCS1194 // Implement exception constructors.

namespace Todos.Core.Exceptions
{
    public class TodoNotFoundException : DomainException
    {
        public TodoNotFoundException(int todoId) : base($"Todo item with id {todoId} not found")
        {
        }
    }
}

#pragma warning restore RCS1194 // Implement exception constructors.