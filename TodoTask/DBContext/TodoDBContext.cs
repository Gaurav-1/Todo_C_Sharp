using Microsoft.EntityFrameworkCore;
using TodoTask.Model;


namespace TodoTask.DBContext
{
    public class TodoDBContext: DbContext
    {
            public TodoDBContext(DbContextOptions<TodoDBContext> options) : base(options) { }

            public DbSet<TodoModel> TodoModels { get; set; }
    }
}
