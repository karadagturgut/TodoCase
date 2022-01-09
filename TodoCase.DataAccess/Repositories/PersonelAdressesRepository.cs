using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using TodoCase.Core.Entities;
using TodoCase.DataAccess.Repository.IRepository;

namespace TodoCase.DataAccess.Repository
{
    public class PersonelAdressesRepository : IPersonelAdressesRepository
    {
        public void Add(PersonAdresses entity)
        {
            throw new NotImplementedException();
        }

        public PersonAdresses Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PersonAdresses> GetAll(Expression<Func<PersonAdresses, bool>> filter = null, Func<IQueryable<PersonAdresses>, IOrderedQueryable<PersonAdresses>> orderBy = null, string includeProperties = null)
        {
            throw new NotImplementedException();
        }

        public PersonAdresses GetFirstOrDefault(Expression<Func<PersonAdresses, bool>> filter = null, string includeProperties = null)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(PersonAdresses entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<PersonAdresses> entity)
        {
            throw new NotImplementedException();
        }

        public void Update(PersonAdresses entity)
        {
            throw new NotImplementedException();
        }
    }
}
