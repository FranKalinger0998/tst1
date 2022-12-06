using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tst1.Models;

namespace tst1.Data
{
    public class ContextToDo : DbContext
    {
        public ContextToDo(DbContextOptions<ContextToDo> options) : base(options)
        {

        }
        public DbSet<ToDo> ToDoSet { get; set; }
                
    }
}
