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
        private readonly TodoContext _context;

        public TodoItemsController(TodoContext context)
        {
            _context = context;
        }

        // GET: api/TodoItems
        [HttpGet]
        public IEnumerable<dtos> GetTodoItems()
        {
            var items = _context.GetTodoItems().Select(item => item.AsDto());
            return items;
        }

        // GET: api/TodoItems/5
        [HttpGet("{id}")]
        public ActionResult<TodoItem> GetTodoItem(Guid id)
        {
            var todoItem = _context.GetTodoItem(id);

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
                    await _context.SaveChangesAsync();
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

        private bool TodoItemExists(Guid id)
        {
            throw new NotImplementedException();
        }

        // POST: api/TodoItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TodoItem>> PostTodoItem(TodoItem todoItem)
        {
          if (_context.GetTodoItems == null)
          {
              return Problem("Entity set 'TodoContext.TodoItems'  is null.");
          }
            //_context.GetTodoItems.Add(todoItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetTodoItem), new { id = todoItem.Id }, todoItem);
        }

        // DELETE: api/TodoItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTodoItem(Guid id)
        {
            if (_context.GetTodoItems == null)
            {
                return NotFound();
            }
            var todoItem = _context.GetTodoItems;
            if (todoItem == null)
            {
                return NotFound();
            }

            //object value = _context.GetTodoItems;
            await _context.SaveChangesAsync();

            return NoContent();
        }

       /* private bool TodoItemExists(Guid id)
        {
            return id; //(_context.GetTodoItems?.Any(e => e.Id == id)).GetValueOrDefault();
        } */
    }
}
