using System.Collections.Generic;
using System.Text;
using Todos.Core.Models;

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