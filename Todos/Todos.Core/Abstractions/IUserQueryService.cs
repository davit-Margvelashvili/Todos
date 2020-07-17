using System.Collections.Generic;
using System.Threading.Tasks;
using Todos.Core.Models;

namespace Todos.Core.Abstractions
{
    public interface IUserQueryService
    {
        Task<List<User>> GetAllAsync();

        Task<User> GetByIdAsync(int id);
    }
}