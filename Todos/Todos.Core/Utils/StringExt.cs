using System;
using System.Collections.Generic;
using System.Text;

namespace Todos.Core.Utils
{
    public static class StringExt
    {
        public static bool IsNullOrEmpty(this string self) => string.IsNullOrEmpty(self);

        public static bool IsNullOrWhiteSpace(this string self) => string.IsNullOrWhiteSpace(self);
    }
}