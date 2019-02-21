using System;
using System.Collections.Generic;
using System.Text;

namespace ToDo.Entities.Tasks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TaskContext _context;

        public UnitOfWork(TaskContext context, ITasksRepository tasks)
        {
            this._context = context;
            this.Tasks = tasks;
        }

        public ITasksRepository Tasks { get; private set; }
        

        public int Complete()
        {
            return this._context.SaveChanges();
        }

        public void Dispose()
        {
            this._context.Dispose();
        }

    }
}
