using System;
using System.Collections.Generic;
using System.Text;
using Todos.Core.Abstractions;

namespace Todos.Services
{
    public class DateTimeProvider : IDateTimeProvider
    {
        public DateTime Now => DateTime.Now;
        public DateTime UtcNow => DateTime.UtcNow;
    }
}