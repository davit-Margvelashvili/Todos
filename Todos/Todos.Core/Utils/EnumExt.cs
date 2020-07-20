using System;

namespace Todos.Core.Utils
{
    public static class EnumExt
    {
        public static TEnum ParseEnum<TEnum>(this string self) =>
            (TEnum)Enum.Parse(typeof(TEnum), self);
    }
}