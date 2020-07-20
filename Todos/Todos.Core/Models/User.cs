using System;
using System.Collections.Generic;
using System.Text;

namespace Todos.Core.Models
{
    public class User
    {
        public static readonly User Empty = new User
        {
            Id = 0,
            Name = string.Empty,
            Password = string.Empty,
            Email = string.Empty
        };

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}