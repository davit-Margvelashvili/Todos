using System;
using System.Collections.Generic;
using System.Text;

namespace Todos.Core.Models
{
    public static class UserExt
    {
        public static bool IsEmpty(this User self) => self == User.Empty;
    }
}