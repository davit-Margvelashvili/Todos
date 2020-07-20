using System;
using System.Collections.Generic;
using System.Text;
using Todos.Core.Abstractions;

namespace Todos.Tests.Infrastructure
{
    internal class FakeDateTimeProvider : IDateTimeProvider
    {
        public DateTime Now => new DateTime(2020, 7, 15, 18, 0, 0);
        public DateTime UtcNow => new DateTime(2020, 7, 15, 14, 0, 0);
        public DateTime Today => new DateTime(2020, 7, 15);
    }
}