using MediatR;
using TodoTask.Model;

namespace TodoTask.Services
{
    public class GetTodoRequest: IRequest<List<TodoGetDTO>> { }
}
