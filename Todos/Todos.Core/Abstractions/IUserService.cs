using System.Threading.Tasks;
using Todos.Core.Models;

namespace Todos.Core.Abstractions
{
    public interface IUserService
    {
        Task<User> RegisterAsync(User user);

        Task<bool> LoginAsync(User user);

        Task<bool> LoginAsync(string userName, string password);
    }
}