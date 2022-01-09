using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using TodoCase.Core.Entities;
using TodoCase.DataAccess.Repository.IRepository;

namespace TodoCase.DataAccess.Repository
{
    class PersonelTaskRepository : IPersonelTaskRepository
    {
        public void Add(PersonelTask entity)
        {
            throw new NotImplementedException();
        }

        public PersonelTask Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PersonelTask> GetAll(Expression<Func<PersonelTask, bool>> filter = null, Func<IQueryable<PersonelTask>, IOrderedQueryable<PersonelTask>> orderBy = null, string includeProperties = null)
        {
            throw new NotImplementedException();
        }

        public PersonelTask GetFirstOrDefault(Expression<Func<PersonelTask, bool>> filter = null, string includeProperties = null)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(PersonelTask entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<PersonelTask> entity)
        {
            throw new NotImplementedException();
        }

        public void Update(PersonelTask entity)
        {
            throw new NotImplementedException();
        }
    }
}
