using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using TodoCase.Core.Entities;
using TodoCase.DataAccess.Repository.IRepository;

namespace TodoCase.DataAccess.Repository
{
    public class TaskRepository : ITaskRepository
    {
        public void Add(Task entity)
        {
            throw new NotImplementedException();
        }

        public Task Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Task> GetAll(Expression<Func<Task, bool>> filter = null, Func<IQueryable<Task>, IOrderedQueryable<Task>> orderBy = null, string includeProperties = null)
        {
            throw new NotImplementedException();
        }

        public Task GetFirstOrDefault(Expression<Func<Task, bool>> filter = null, string includeProperties = null)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Task entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<Task> entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Task entity)
        {
            throw new NotImplementedException();
        }
    }
}
