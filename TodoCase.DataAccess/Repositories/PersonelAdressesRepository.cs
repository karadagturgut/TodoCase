using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using TodoCase.Core.Entities;
using TodoCase.DataAccess.Data;
using TodoCase.DataAccess.Repositories;
using TodoCase.DataAccess.Repository.IRepository;

namespace TodoCase.DataAccess.Repository
{
    public class PersonelAdressesRepository : Repository<PersonAdresses>, IPersonelAdressesRepository
    {
        private readonly ApplicationDbContext _db;
        public PersonelAdressesRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        /// <summary>
        /// Person ID'ye göre adresleri getirir.
        /// </summary>
        /// <param name="personId"></param>
        /// <returns></returns>
        public IQueryable<PersonAdresses> GetByPersonId(int personId)
        {

            var value = _db.PersonAdresses.Where(x => x.PersonId == personId);
            return value;
        }


    }
}
