using Microsoft.EntityFrameworkCore;
using Todos.Core.Models;

namespace Todos.Data
{
    public class TodosDbContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }
        public DbSet<User> Users { get; set; }

        public TodosDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}