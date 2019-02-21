using System;
using System.Collections.Generic;
using ToDo.Entities.Tasks.Models;

namespace ToDo.Entities.Tasks
{
    public interface ITasksRepository : IRepository<Task>
    {
        IEnumerable<Task> ActiveTasks();
        IEnumerable<Task> CompletedTasks();
        IEnumerable<Task> OverDueTasks();
    }
}
