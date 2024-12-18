using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TodoTask.DBContext;
using TodoTask.Model;

namespace TodoTask.Services.Handlers
{
    public class GetTodoHandler: IRequestHandler<GetTodoRequest, List<TodoGetDTO>>
    {
        private readonly IMapper _mapper;
        private readonly TodoDBContext _context;

        public GetTodoHandler(TodoDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<TodoGetDTO>> Handle(GetTodoRequest request, CancellationToken cancellationToken)
        {
            var entities = await _context.TodoModels.ToListAsync(cancellationToken);
            return _mapper.Map<List<TodoGetDTO>>(entities);
        }
    }
}
