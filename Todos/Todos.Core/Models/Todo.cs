using System;
using System.Collections.Generic;
using System.Text;

namespace Todos.Core.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DueDate { get; set; }
        public User AssignedTo { get; set; }
        public TodoStatus Status { get; set; }
        public TodoPriority Priority { get; set; }
    }
}