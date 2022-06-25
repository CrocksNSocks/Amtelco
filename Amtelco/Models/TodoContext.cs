using System;
using System.Collections.Generic;
using TodoApi.Models;

namespace TodoApi.Models
{

    public interface TodoContext
    {
        TodoItem GetItem(Guid id);
        IEnumerable<TodoItem> GetItems();
        void CreateItem(TodoItem item);
        void UpdateItem(TodoItem item);
        void DeleteItem(Guid id);

    }
}
