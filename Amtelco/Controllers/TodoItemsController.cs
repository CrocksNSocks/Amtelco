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
        public IEnumerable<dtos> GetItems()
        {
            var items = context.GetItems().Select(item => item.AsDto());
            return items; //items;
        }

        // GET: api/TodoItems/5
        [HttpGet("{id}")]
        public ActionResult<dtos> GetItem(Guid id)
        {
            var item = context.GetItem(id);

            if (item is null)
            {
                return NotFound();
            }

            return item.AsDto();
        }

     /*   // PUT: api/TodoItems/5
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
        }*/

        // POST /TodoItems
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

            return CreatedAtAction(nameof(GetItem), new { id = item.Id}, item.AsDto());
        }

        // PUT /TodoItems{id}
        [HttpPut("{id}")]
        public ActionResult UpdateItem(Guid id, UpdateItemDTO itemDTO)
        {
            var existingItem = context.GetItem(id);

            if (existingItem is null)
            {
                return NotFound();
            }

            TodoItem updatedItem = existingItem with
            {
                Created = itemDTO.Created,
                LastChanged = itemDTO.LastChanged,
                Start = itemDTO.Start,
                Duration = itemDTO.Duration,
                Description = itemDTO.Description,
                IsComplete = itemDTO.IsComplete
            };

            context.UpdateItem(updatedItem);

            return NoContent();
        }

        //DELETE /items/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteItem(Guid id)
        {
            var existingItem = context.GetItem(id);

            if (existingItem is null)
            {
                return NotFound();
            }

            context.DeleteItem(id);
            return NoContent();
        }

        private bool TodoItemExists(Guid id)
        {
            throw new NotImplementedException();
        }

     /*   // POST: api/TodoItems
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
