using System;
using System.Collections.Generic;
using System.Text;

namespace Todos.Core.Abstractions
{
    public interface IDateTimeProvider
    {
        DateTime Now { get; }
        DateTime UtcNow { get; }

        DateTime Today { get; }
    }
}