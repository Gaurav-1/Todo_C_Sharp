using TodoTask.Interfaces;
using TodoTask.Model;
using TodoTask.Services;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using TodoTask.Services.Handlers;

namespace TodoTask.Controller
{

    [ApiController]
    [Route("api/[controller]")]
    public class TodoController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TodoController(IMediator mediator) => _mediator = mediator;

        public async Task<ActionResult<List<TodoGetDTO>>> GetTodos()
        {
            var result = await _mediator.Send(new GetTodoRequest());
            return Ok(result);
        }

        public async Task<ActionResult<int>> CreateTodoItem(TodoCreatedDTO createTodoItem)
        {
            var command = new CreateTodoRequest { TodoModels = createTodoItem };
            var id = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetTodos), new { id }, id);
        }
    }
}
