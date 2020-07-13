using Todos.Core.Models;

#pragma warning disable RCS1194 // Implement exception constructors.

namespace Todos.Core.Exceptions
{
    public class UserAlreadyRegisteredException : DomainException
    {
        public UserAlreadyRegisteredException(User user)
            : base($"User '{user.Email}' has already been registered")
        {
        }
    }
}

#pragma warning restore RCS1194 // Implement exception constructors.