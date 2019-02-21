using System;
namespace ToDo.Entities.Tasks
{
    public interface IUnitOfWork : IDisposable
    {
        ITasksRepository Tasks { get; }
        int Complete();
    }
}
