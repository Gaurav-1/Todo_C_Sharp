using MediatR;
using TodoTask.Model;


namespace TodoTask.Services
{
    public class CreateTodoRequest: IRequest<int>
    {
        public TodoCreatedDTO TodoModels { get; set; }
    }
}
