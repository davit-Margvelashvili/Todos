using System.Threading.Tasks;
using Todos.Core.Models;

namespace Todos.Core.Abstractions
{
    public interface IUserCommandService
    {
        Task<User> RegisterAsync(User user);

        Task<User> LoginAsync(User user);

        Task<User> LoginAsync(string userName, string password);
    }
}