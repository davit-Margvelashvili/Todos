using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Todos.Data
{
    public class TodoContextFactory : IDesignTimeDbContextFactory<TodosDbContext>
    {
        public TodosDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<TodosDbContext>()
                .UseSqlServer(@"Data Source = (localdb)\MSSQLLocalDb; Initial Catalog = Todos");

            return new TodosDbContext(optionsBuilder.Options);
        }
    }
}