using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Amtelco.DTOS;
using Amtelco.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

namespace Amtelco.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoItemsController : ControllerBase
    {
        private readonly TodoContext context;

        public TodoItemsController(TodoContext context)
        {
            this.context = context;
        }

        // GET: api/TodoItems
        [HttpGet]
        public IEnumerable<dtos> GetTodoItems()
        {
            //var items = _context.GetTodoItems().Select(item => item.AsDto());
            return null; //items;
        }

        // GET: api/TodoItems/5
        [HttpGet("{id}")]
        public ActionResult<TodoItem> GetTodoItem(Guid id)
        {
            var todoItem = context.GetTodoItem(id);

            if (todoItem is null)
            {
                return NotFound();
            }

            return NoContent();
        }

        // PUT: api/TodoItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTodoItem(Guid id, TodoItem GettodoItem)
        {
            if (id == GettodoItem.Id)
            {
               // _context.Entry(GettodoItem).State = EntityState.Modified;

                try
                {
                    await context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TodoItemExists(id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return NoContent();
            }
            return BadRequest();
        }

        // POST /items
        [HttpPost]
        public ActionResult<dtos> CreateItem(CreateTodoItemDTO itemDTO)
        {
            TodoItem item = new()
            {
                Id = Guid.NewGuid(),
                UserId = Guid.NewGuid(),
                Created = itemDTO.Created,
                LastChanged = itemDTO.LastChanged,
                Start = itemDTO.Start,
                Duration = itemDTO.Duration,
                Description = itemDTO.Description,
                IsComplete = itemDTO.IsComplete
            };

            context.CreateItem(item);

            return CreatedAtAction(nameof(GetTodoItem), new { id = item.Id}, item.AsDto());
        }

        private bool TodoItemExists(Guid id)
        {
            throw new NotImplementedException();
        }

        // POST: api/TodoItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TodoItem>> PostTodoItem(TodoItem todoItem)
        {
          if (context.GetTodoItems == null)
          {
              return Problem("Entity set 'TodoContext.TodoItems'  is null.");
          }
            //_context.GetTodoItems.Add(todoItem);
            await context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetTodoItem), new { id = todoItem.Id }, todoItem);
        }

        // DELETE: api/TodoItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTodoItem(Guid id)
        {
            if (context.GetTodoItems == null)
            {
                return NotFound();
            }
            var todoItem = context.GetTodoItems;
            if (todoItem == null)
            {
                return NotFound();
            }

            //object value = _context.GetTodoItems;
            await context.SaveChangesAsync();

            return NoContent();
        }

       /* private bool TodoItemExists(Guid id)
        {
            return id; //(_context.GetTodoItems?.Any(e => e.Id == id)).GetValueOrDefault();
        } */
    }
}
