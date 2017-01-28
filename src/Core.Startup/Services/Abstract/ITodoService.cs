using Core.Startup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Startup.Services.Abstract
{
    // operations you want to expose
    public interface ITodoService
    {
        IEnumerable<Todo> GetTodos();
        Todo GetTodo(int id);
        void CreateTodo(Todo todo);
        void UpdateTodo(Todo todo);

    }

}
