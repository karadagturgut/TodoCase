using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using TodoCase.Core.Entities;
using TodoCase.DataAccess.Repository.IRepository;

namespace TodoCase.DataAccess.Repository
{
    public class PersonRepository : IPersonRepository
    {
        public void Add(Person entity)
        {
            throw new NotImplementedException();
        }

        public Person Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> GetAll(Expression<Func<Person, bool>> filter = null, Func<IQueryable<Person>, IOrderedQueryable<Person>> orderBy = null, string includeProperties = null)
        {
            throw new NotImplementedException();
        }

        public Person GetFirstOrDefault(Expression<Func<Person, bool>> filter = null, string includeProperties = null)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Person entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<Person> entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Person entity)
        {
            throw new NotImplementedException();
        }
    }
}
