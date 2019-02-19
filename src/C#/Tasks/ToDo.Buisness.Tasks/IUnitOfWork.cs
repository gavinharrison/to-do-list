using System;
namespace ToDo.Buisness.Tasks
{
    public interface IUnitOfWork : IDisposable
    {
        ITasksRepository Tasks();
        int Complete();
    }
}
