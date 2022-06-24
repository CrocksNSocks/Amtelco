using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace TodoApi.Models
{
    public class TodoContext
    {
            private readonly List<TodoItem> _items = new()
            {
                new TodoItem { Id = Guid.NewGuid(),
                               UserId = Guid.NewGuid(),
                               Created = 112,
                               LastChanged = 115,
                               Start = 1200,
                               Duration = 22,
                               Name = "Thom Yorke",
                               Description = "Meeting about Conan O'Brian Interview",
                               IsComplete = true
                              }

             };
        public IEnumerable<TodoItem> GetTodoItems()
        {
            return _items;
        }

        public TodoItem GetTodoItem(Guid id)
        {
            return _items.Where(item => item.Id == id).SingleOrDefault();
        }

        internal Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
