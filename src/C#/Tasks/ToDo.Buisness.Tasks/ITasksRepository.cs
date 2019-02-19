using System;
using System.Collections.Generic;
using ToDo.Dto.Tasks;

namespace ToDo.Buisness.Tasks
{
    public interface ITasksRepository : IRepository<Task>
    {
        IEnumerable<Task> CompletedTasks();
        IEnumerable<Task> OverDueTasks();
    }
}
