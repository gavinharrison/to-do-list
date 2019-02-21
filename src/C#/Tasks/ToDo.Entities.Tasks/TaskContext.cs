using Microsoft.EntityFrameworkCore;
using ToDo.Entities.Tasks.Models;

namespace ToDo.Entities.Tasks
{
    public class TaskContext : DbContext
    {
        public TaskContext(DbContextOptions<TaskContext> options)
            : base(options)
        { }

        public DbSet<Task> Tasks { get; set; }
    }
}
