using Core.Startup.Models;
using Core.Startup.Data.Abstract;

namespace Core.Startup.Data.Repositories
{
    public class TodoRepository : EntityBaseRepository<Todo>, ITodoRepository
    {
        public TodoRepository(StartupDbContext context)
            : base(context)
        { }
    }
}
