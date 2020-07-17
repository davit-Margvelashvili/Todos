using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace Todos.WinFormsUi
{
    internal static class ServiceContainer
    {
        private static IServiceProvider _serviceProvider;

        public static void Initializer(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public static T Get<T>() => _serviceProvider.GetRequiredService<T>();
    }
}