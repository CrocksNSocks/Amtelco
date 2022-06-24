using System;
using TodoApi.Models;


namespace Amtelco.DTOS
{
    public record dtos
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public int Created { get; set; }
        public int LastChanged { get; set; }
        public int Start { get; set; }
        public int Duration { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public bool IsComplete { get; set; }
    }
}
