using Amtelco.DTOS;
using TodoApi.Models;

namespace Amtelco.Models
{
    public static class Extensions
    {
        public static dtos AsDto(this TodoItem todoItem)
        {
            return new dtos
            {
                Id = todoItem.Id,
                UserId = todoItem.UserId,
                Created = todoItem.Created,
                LastChanged = todoItem.LastChanged,
                Start = todoItem.Start,
                Duration = todoItem.Duration,
                Name = todoItem.Name,
                Description = todoItem.Description,
                IsComplete = todoItem.IsComplete
            };
        }
    }
}
