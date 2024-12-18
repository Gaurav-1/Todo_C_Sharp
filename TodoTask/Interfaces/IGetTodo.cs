using System.Collections.Generic;
using TodoTask.Model;

namespace TodoTask.Interfaces
{
    public interface IGetTodo
    {
        List<TodoModel> GetAllTodo();
        TodoModel GetTodoById(int id);
    }
}
