using System;
using System.Collections.Generic;
using Todos.Core.Models;

namespace Todos.Tests.Infrastructure
{
    internal class TodoEqualityComparer : IEqualityComparer<Todo>
    {
        public static readonly TodoEqualityComparer Default = new TodoEqualityComparer();

        public bool Equals(Todo x, Todo y)
        {
            if (x is null && y is null) return true;
            if (x is null || y is null) return false;

            return x.Id == y.Id
                   && x.UserId == y.UserId
                   && x.Title == y.Title
                   && x.Description == y.Description
                   && x.StartDate == y.StartDate
                   && x.DueDate == y.DueDate
                   && x.Status == y.Status
                   && x.Priority == y.Priority;
        }

        public int GetHashCode(Todo obj) => obj.Id;
    }

    internal class UserEqualityComparer : IEqualityComparer<User>
    {
        public static readonly UserEqualityComparer Default = new UserEqualityComparer();

        public bool Equals(User x, User y)
        {
            if (x is null && y is null) return true;
            if (x is null || y is null) return false;

            return x.Id == y.Id
                   && x.Name == y.Name
                   && x.Password == y.Password
                   && x.Email == y.Email;
        }

        public int GetHashCode(User obj) => obj.Id;
    }
}