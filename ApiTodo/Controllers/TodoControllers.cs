using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


[ApiController]
[Route("api/todo")]
public class TodoController : ControllerBase
{
private readonly TodoContext _context;
public TodoController(TodoContext context)
{
_context = context;
}


// GET: api/todo
[HttpGet]
public async Task<ActionResult<IEnumerable<Todo>>> GetTodos()
{
// Get items
var todos = _context.Todos;
return await todos.ToListAsync();
}
}

