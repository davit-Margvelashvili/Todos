using System;
using System.Collections.Generic;
using System.Text;

namespace Todos.Core.Exceptions
{
    public class TodoNotFoundException : DomainException
    {
        public TodoNotFoundException(int todoId) : base($"Todo item with id {todoId} not found")
        {
        }
    }
}