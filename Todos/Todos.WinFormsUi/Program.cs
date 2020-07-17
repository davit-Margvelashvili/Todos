using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using Todos.Core.Abstractions;
using Todos.Data;
using Todos.Services;
using Todos.WinFormsUi.Forms;

namespace Todos.WinFormsUi
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            ConfigureServices(services);

            using (var serviceProvider = services.BuildServiceProvider())
            {
                var mainForm = serviceProvider.GetRequiredService<MainForm>();

                Application.Run(mainForm);
            }
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<ITodoCommandService, TodoCommandService>()
                .AddSingleton<ITodoQueryService, TodoQueryService>()
                .AddSingleton<IUserService, UserService>()
                .AddSingleton<IDateTimeProvider, DateTimeProvider>()
                .AddSingleton<MainForm>()
                .AddDbContext<TodosDbContext>(options =>
                    options.UseSqlServer(@"Data Source = (localdb)\MSSQLLocalDb; Initial Catalog = Todos"));
        }
    }
}