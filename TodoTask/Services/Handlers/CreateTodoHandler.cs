using AutoMapper;
using MediatR;
using TodoTask.DBContext;
using TodoTask.Model;


namespace TodoTask.Services.Handlers
{
    public class CreateTodoHandler: IRequestHandler<CreateTodoRequest, int>
    {
        private readonly TodoDBContext _context;
        private readonly IMapper _mapper;
        public CreateTodoHandler(TodoDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateTodoRequest request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<TodoModel>(request.TodoModels);
            _context.TodoModels.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);
            return entity.Id;
        }
    }
}
