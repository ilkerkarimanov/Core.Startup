using Core.Startup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Startup.Models
{
    public class Todo : IEntityBase
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
