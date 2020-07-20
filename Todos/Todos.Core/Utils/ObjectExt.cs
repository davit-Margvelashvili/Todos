using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Todos.Core.Utils
{
    public static class ObjectExt
    {
        public static T DeepCopy<T>(this T self) =>
            JsonSerializer.Deserialize<T>(JsonSerializer.Serialize(self));

        public static T DeserializeAs<T>(this string self) => JsonSerializer.Deserialize<T>(self);

        public static string Serialize<T>(this T self) => JsonSerializer.Serialize(self);
    }
}