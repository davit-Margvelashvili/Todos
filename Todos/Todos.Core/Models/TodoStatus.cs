namespace Todos.Core.Models
{
    public enum TodoStatus : byte
    {
        New = 0,
        Doing = 10,
        Done = 20,
        Rejected = 99
    }
}