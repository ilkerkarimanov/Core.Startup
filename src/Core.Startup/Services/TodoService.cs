using Core.Startup.Models;
using Core.Startup.Services.Abstract;
using Core.Startup.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Startup.Services
{
    
    public class TodoService : ITodoService
    {
        private readonly ITodoRepository _todoRepository;

        public TodoService(ITodoRepository todoRepository)
        {
            this._todoRepository = todoRepository;
        }

        #region ITodoService Members

        public IEnumerable<Todo> GetTodos()
        {
            var todos = _todoRepository.GetAll();
            return todos;
        }
        public Todo GetTodo(int id)
        {
            var todo = _todoRepository.GetSingle(id);
            return todo;
        }
        
        public void CreateTodo(Todo todo)
        {
            _todoRepository.Add(todo);
            _todoRepository.Commit();
        }
        public void UpdateTodo(Todo todo)
        {
            _todoRepository.Update(todo);
            _todoRepository.Commit();
        }

        #endregion
    }
}
