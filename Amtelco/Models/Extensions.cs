using Amtelco.DTOS;
using TodoApi.Models;

namespace Amtelco.Models
{
    public static class Extensions
    {
        public static dtos AsDto(this TodoItem item)
        {
            return new dtos
            {
                Id = item.Id,
                UserId = item.UserId,
                Created = item.Created,
                LastChanged = item.LastChanged,
                Start = item.Start,
                Duration = item.Duration,
                Name = item.Name,
                Description = item.Description,
                IsComplete = item.IsComplete
            };
        }
    }
}
