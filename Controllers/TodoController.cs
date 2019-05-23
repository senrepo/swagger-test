using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SwaggerTest.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace SwaggerTest.Controllers
{
    [Route("api/[controller]")]
    public class TodoController : ControllerBase
    {

        
        [HttpPost("Create")]
        [SwaggerOperation(Summary = "Creates a new Todo item")]
        public ActionResult<TodoItem> Create(TodoItem item)
        {
            return Ok(item);
        }


        [HttpGet("GetAll")]
        [SwaggerOperation(Summary = "Retrieves all Todo items")]
        public ActionResult<List<TodoItem>> GetAll()
        {
            var list = new List<TodoItem>() {
                new TodoItem() { Id = 1, Name = "Item1", IsComplete = false },
                  new TodoItem() { Id = 2, Name = "Item2", IsComplete = false },
                    new TodoItem() { Id = 3, Name = "Item3", IsComplete = false }
            };

            return Ok(list);
        }
    }
}