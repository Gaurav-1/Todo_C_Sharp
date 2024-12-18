using AutoMapper;
using TodoTask.Model;

namespace TodoTask.Mapper
{
    public class TodoAutoMapper: Profile
    {
        public TodoAutoMapper()
        {
            CreateMap<TodoModel, TodoGetDTO>();
            CreateMap<TodoCreatedDTO, TodoModel>();
        }
    }
}
