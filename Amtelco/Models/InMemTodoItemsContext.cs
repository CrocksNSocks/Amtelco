using System;
using System.Collections.Generic;
using System.Linq;
using TodoApi.Models;

namespace Amtelco.Models
{
    public class InMemTodoItemsContext : TodoContext
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

        public void CreateItem(TodoItem item)
        {
            _items.Add(item);
        }

        public TodoItem GetItem(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TodoItem> GetItems()
        {
            throw new NotImplementedException();
        }

        object TodoContext.GetTodoItem(Guid id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<object> TodoContext.GetTodoItems()
        {
            throw new NotImplementedException();
        }

        Task TodoContext.SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public void UpdateItem(TodoItem item)
        {
            throw new NotImplementedException();
        }
    }
}
