using System;
using System.Collections.Generic;
using System.Linq;
using ToDo.Entities.Tasks.Models;

namespace ToDo.Entities.Tasks
{
    public class TaskRepository : Repository<Task>, ITasksRepository
    {
        protected TaskContext TaskContext { get { return this.Context as TaskContext; } }

        public TaskRepository(TaskContext context)
            : base(context)
        { }

        public IEnumerable<Task> ActiveTasks()
        {
            return this.TaskContext
                       .Tasks
                       .Where(x => !x.Completed)
                       .ToList();
        }

        public IEnumerable<Task> CompletedTasks()
        {
            return this.TaskContext
                       .Tasks
                       .Where(x => x.Completed)
                       .ToList();
        }

        public IEnumerable<Task> OverDueTasks()
        {
            return this.TaskContext
                       .Tasks
                       .Where(x => x.DueDate >= DateTime.Now)
                       .ToList();
        }
    }
}
