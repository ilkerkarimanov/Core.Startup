using System;
using System.Linq;
using Core.Startup.Models;

namespace Core.Startup.Data
{
    public class StartupbInitializer
    {
        private static StartupDbContext context;
        public static void Initialize(IServiceProvider serviceProvider)
        {
            context = (StartupDbContext)serviceProvider.GetService(typeof(StartupDbContext));

            InitializeSchedules();
        }

        private static void InitializeSchedules()
        {
            if (!context.Todos.Any())
            {
                Todo todo_01 = new Todo
                {
                    Description = "Buy milk"
                };

                Todo todo_02 = new Todo
                {
                    Description = "Get food for the dogs"
                };

                context.Todos.Add(todo_01); context.Todos.Add(todo_02);

                context.SaveChanges();
            }
        }
    }
}