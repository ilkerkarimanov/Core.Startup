using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Core.Startup.Data.Abstract;
using Core.Startup.Models;
using AutoMapper;
using Core.Startup.Models;
using Core.Startup.Services.Abstract;

namespace Core.Startup.Controllers
{
    [Route("api/[controller]")]
    public class TodosController:Controller 
    {
        ITodoService _todoService;
        public TodosController(
        ITodoService todoService)
        {
            _todoService = todoService;
        }

        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Todo> _matches = _todoService.GetTodos();
            IEnumerable<TodoViewModel> _matchesVM = Mapper.Map<IEnumerable<Todo>, IEnumerable<TodoViewModel>>(_matches);
            return Ok(_matchesVM);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]TodoViewModel vm)
        {
            var entity = _todoService.GetTodo(vm.Id);
                if (entity == null) return NotFound();
            entity = Mapper.Map<TodoViewModel, Todo>(vm);
            _todoService.UpdateTodo(entity);
            return Ok();
        }

        [HttpPost]
        public IActionResult Post([FromBody]string description)
        {
            if (string.IsNullOrEmpty(description)) return new StatusCodeResult(400);
            var entity = new Todo() { Description = description };
            _todoService.CreateTodo(entity);
            return Ok();
        }
    
    }
}
